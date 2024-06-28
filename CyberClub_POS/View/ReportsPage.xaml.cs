using SimpleWPFReporting;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CyberClub_POS.View
{
    public partial class ReportsPage : Page
    {
        public ReportsPage()
        {
            InitializeComponent();
        }
        public class Sales
        {
            public string CategoryName { get; set; }
            public string PeriodName { get; set; }
        }

        public class SalesContext : DbContext
        {
            public DbSet<Sales> Sales { get; set; }
            public SalesContext() : base("name=PosSystemDBEntities")
            {
            }
        }

        public struct SalesStruct
        {
            public int SaleID { get; set; }
            public string FullName { get; set; }
            public string ProductName { get; set; }
            public string CategoryName { get; set; }
            public string PeriodName { get; set; }
            public string DayName { get; set; }
            public decimal Amount { get; set; }
            public DateTime SaleTime { get; set; }
            public string PaymentMethod { get; set; }
        }

        public class SaleWithDetails
        {
            public int SaleID { get; set; }
            public int UserID { get; set; }
            public int ProductID { get; set; }
            public int PriceID { get; set; }
            public decimal Amount { get; set; }
            public DateTime SaleTime { get; set; }
            public string PaymentMethod { get; set; }
            public string FullName { get; set; }
            public string ProductName { get; set; }
            public string CategoryName { get; set; }
        }

        private void GenerateReport_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime? startDate = startDatePicker.SelectedDate;
                DateTime? endDate = endDatePicker.SelectedDate;

                if (startDate == null || endDate == null)
                {
                    MessageBox.Show("Пожалуйста, выберите обе даты.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                using (var context = new PosSystemDBEntities())
                {
                    var salesData = from sale in context.Sales
                                    join user in context.Users on sale.UserID equals user.UserID
                                    join pricecat in context.Prices on sale.PriceID equals pricecat.PriceID
                                    join product in context.Products on sale.ProductID equals product.ProductID
                                    join category in context.Categories on pricecat.CategoryID equals category.CategoryID
                                    where sale.SaleTime >= startDate && sale.SaleTime <= endDate
                                    select new SaleWithDetails
                                    {
                                        SaleID = (int)sale.SaleID,
                                        UserID = (int)sale.UserID,
                                        ProductID = (int)sale.ProductID,
                                        PriceID = (int)sale.PriceID,
                                        Amount = (decimal)sale.Amount,
                                        SaleTime = (DateTime)sale.SaleTime,
                                        PaymentMethod = sale.PaymentMethod,
                                        FullName = user.FullName,
                                        ProductName = product.ProductName,
                                        CategoryName = category.CategoryName
                                    };

                    var salesList = salesData.ToList();
                    DisplayDataInDataGrid(salesList);

                    Task.Delay(100).ContinueWith(_ =>
                    {
                        Dispatcher.Invoke(() => GenerateReport(salesList));
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при создании отчета: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public class SalesViewModel
        {
            public int SaleID { get; set; }
            public string FullName { get; set; }
            public string ProductName { get; set; }
            public string CategoryName { get; set; }
            public string PeriodName { get; set; }
            public string DayName { get; set; }
            public decimal Amount { get; set; }
            public DateTime SaleTime { get; set; }
            public string PaymentMethod { get; set; }
        }

        private void DisplayDataInDataGrid(List<SaleWithDetails> salesData)
        {
            reportContainer.Children.Clear();

            var dataGrid = new DataGrid
            {
                AutoGenerateColumns = false,
                Margin = new Thickness(0, 0, 0, 10)
            };

            var saleIdColumn = new DataGridTextColumn
            {
                Header = "№",
                Binding = new System.Windows.Data.Binding("SaleID")
            };
            dataGrid.Columns.Add(saleIdColumn);

            var fullNameColumn = new DataGridTextColumn
            {
                Header = "Клиент",
                Binding = new System.Windows.Data.Binding("FullName")
            };
            dataGrid.Columns.Add(fullNameColumn);

            var productNameColumn = new DataGridTextColumn
            {
                Header = "Продукты",
                Binding = new System.Windows.Data.Binding("ProductName")
            };
            dataGrid.Columns.Add(productNameColumn);

            var categoryNameColumn = new DataGridTextColumn
            {
                Header = "Тариф",
                Binding = new System.Windows.Data.Binding("CategoryName")
            };
            dataGrid.Columns.Add(categoryNameColumn);

            var amountColumn = new DataGridTextColumn
            {
                Header = "Сумма",
                Binding = new System.Windows.Data.Binding("Amount")
            };
            dataGrid.Columns.Add(amountColumn);

            var saleTimeColumn = new DataGridTextColumn
            {
                Header = "Время",
                Binding = new System.Windows.Data.Binding("SaleTime")
            };
            dataGrid.Columns.Add(saleTimeColumn);

            var paymentMethodColumn = new DataGridTextColumn
            {
                Header = "Метод оплаты",
                Binding = new System.Windows.Data.Binding("PaymentMethod")
            };
            dataGrid.Columns.Add(paymentMethodColumn);

            dataGrid.ItemsSource = salesData;
            reportContainer.Children.Add(dataGrid);
        }

        private void GenerateReport(List<SaleWithDetails> salesData)
        {
            RenderTargetBitmap renderTargetBitmap = new RenderTargetBitmap((int)reportContainer.ActualWidth, (int)reportContainer.ActualHeight, 96, 96, PixelFormats.Pbgra32);
            renderTargetBitmap.Render(reportContainer);

            BitmapSource bitmapSource = renderTargetBitmap;

            Image reportImage = new Image
            {
                Source = bitmapSource,
                Margin = new Thickness(0, 0, 0, 10)
            };

            reportContainer.Children.Clear();
            reportContainer.Children.Add(reportImage);

            object dataContext = new { Name = "Отчет по продажам", Date = DateTime.Now };
            Thickness margin = new Thickness(20);
            ReportOrientation orientation = ReportOrientation.Portrait;

            DataTemplate headerTemplate = (DataTemplate)this.Resources["ReportHeaderDataTemplate"];
            DataTemplate footerTemplate = (DataTemplate)this.Resources["ReportFooterDataTemplate"];

            string filePath = "SalesReport.pdf";
            Report.ExportReportAsPdf(
                reportContainer,
                dataContext,
                margin,
                orientation,
                null,
                Brushes.White,
                headerTemplate,
                false,
                footerTemplate,
                false
            );

            MessageBox.Show($"Отчет успешно создан и сохранен в {filePath}", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
