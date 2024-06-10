using CyberClub_POS.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using static CyberClub_POS.View.SettingsPage;

namespace CyberClub_POS.View
{
    public partial class SalesPage : Page, INotifyPropertyChanged
    {
        PosSystemDBEntities card = new PosSystemDBEntities();
        List<Products> sett1 = new List<Products>();
        private decimal totalAmount;

        public event PropertyChangedEventHandler PropertyChanged;

        private void Switch_UserManagement_CLick(object sender, RoutedEventArgs e)
        {
            UserManagementWindow userManagementWindow = new UserManagementWindow();
            userManagementWindow.Show();
        }

        private void Switch_QR_sbp_CLick(object sender, RoutedEventArgs e)
        {
            SbpWindow sbpWindow = new SbpWindow();
            sbpWindow.Show();
        }


        public string TotalAmountFormatted
        {
            get
            {
                if (totalAmount % 1 == 0)
                {
                    return $"{totalAmount:F0} ₽";
                }
                else
                {

                    int decimalPlaces = (BitConverter.GetBytes(decimal.GetBits(totalAmount)[3])[2]);
                    decimalPlaces = Math.Min(decimalPlaces, 2);
                    return $"{totalAmount.ToString($"F{decimalPlaces}")} ₽";
                }
            }
        }

        public SalesPage()
        {
            InitializeComponent();
            DataContext = this;

            List<Categories> clist = card.Categories.ToList();
            foreach (Categories item in clist)
            {
                CategoryCB.Items.Add(item.CategoryName);
            }

            List<Days> dlist = card.Days.ToList();
            foreach (Days item in dlist)
            {
                DaysCB.Items.Add(item.DayName);
            }

            List<Periods> plist = card.Periods.ToList();
            foreach (Periods item in plist)
            {
                TimeCB.Items.Add(item.PeriodName);
            }

            FoodSale.ItemsSource = card.Products.Where(c => c.ProdCategory == "Еда").ToList();
            DrinksSale.ItemsSource = card.Products.Where(c => c.ProdCategory == "Напитки").ToList();

            GoodsCard_DG.ItemsSource = sett1.ToList();
            PaymentMethod_ComboBox.Items.Add("Наличный расчет");
            PaymentMethod_ComboBox.Items.Add("Эквайринг");
            PaymentMethod_ComboBox.Items.Add("СБП");

            List<Users> list = card.Users.ToList();
            foreach (Users user in list)
            {
                string formattedBirthDate = user.BirthDate.HasValue ? user.BirthDate.Value.ToShortDateString() : "N/A";
                UserSelect_ComboBox.Items.Add($" {user.FullName}, {user.PhoneNumber}, {formattedBirthDate}" );
            }

            PaymentMethod_ComboBox.SelectedIndex = 0;
            CategoryCB.SelectedIndex = 0;
            DaysCB.SelectedIndex = 0;
            TimeCB.SelectedIndex = 0;
        }


        public class ProductInfo
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int AvailableQuantity { get; set; }

            public override string ToString()
            {
                return $"{Name}, {Price.ToString(Price % 1 == 0 ? "F0" : "F2")} ₽, {AvailableQuantity} в нал.";
            }
        }
        public class SaleItem
        {
            public string CategoryName { get; set; }
            public string PeriodName { get; set; }
            public decimal Price { get; set; }

            public override string ToString()
            {
                return $"{CategoryName}, {PeriodName}, {Price} руб.";
            }
        }
        public List<Products> lisst = new List<Products>();

        private void DrinksSale_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            var sett = (Products)DrinksSale.SelectedItem;
            lisst.Add(sett);
            sett1.Add(sett);
            GoodsCard_DG.ItemsSource = lisst.ToList();
        }

        private void FoodSale_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var sett = (Products)FoodSale.SelectedItem;
            lisst.Add(sett);
            sett1.Add(sett);
            GoodsCard_DG.ItemsSource = lisst.ToList();
        }



        private void Pay_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CategoryCB.SelectedItem == null || DaysCB.SelectedItem == null || TimeCB.SelectedItem == null || UserSelect_ComboBox.SelectedItem == null || PaymentMethod_ComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Пожалуйста, заполните все поля перед оплатой.");
                    return;
                }

                Categories elem1 = card.Categories.FirstOrDefault(c => c.CategoryName == CategoryCB.SelectedItem.ToString());
                Days elem2 = card.Days.FirstOrDefault(c => c.DayName == DaysCB.SelectedItem.ToString());
                Periods elem3 = card.Periods.FirstOrDefault(c => c.PeriodName == TimeCB.SelectedItem.ToString());

                if (elem1 == null || elem2 == null || elem3 == null)
                {
                    MessageBox.Show("Выбранные данные не найдены в базе данных.");
                    return;
                }

                string[] userParts = UserSelect_ComboBox.SelectedItem.ToString().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                string fullName = userParts[0].Trim();
                Users elem4 = card.Users.FirstOrDefault(c => c.FullName == fullName);

    
                if (elem4 == null)
                {
                    MessageBox.Show("Пользователь не найден.");
                    return;
                }
              
                string paymentMethod = PaymentMethod_ComboBox.SelectedItem.ToString();

                Prices select = card.Prices.FirstOrDefault(c => c.CategoryID == elem1.CategoryID && c.DayID == elem2.DayID && c.PeriodID == elem3.PeriodID);

                if (select != null)
                {
                    Products prodd = new Products();
                    foreach (Products Item in sett1)
                    {
                        prodd = Item;
                    }

                    Sales newSale = new Sales
                    {
                        Amount = Convert.ToDecimal(select.Price + prodd.Price),
                        UserID = elem4.UserID,
                        PriceID = select.PriceID,
                        SaleTime = DateTime.Now,
                        PaymentMethod = paymentMethod,
                        ProductID = prodd.ProductID
                    };

                    card.Sales.Add(newSale);
                    card.SaveChanges();

                    Sales newsale = card.Sales.FirstOrDefault(c => c.SaleID == card.Sales.Count());

                    MessageBox.Show("Покупка завершена!");
                    card.SaveChanges();

                    sett1.Clear();
                    GoodsCard_DG.ItemsSource = sett1.ToList();
                }
                else
                {
                    MessageBox.Show("Соответствующая запись не найдена.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
        private void Clear_card_btn(object sender, RoutedEventArgs e)
        {

            sett1.Clear();
            GoodsCard_DG.ItemsSource = sett1.ToList();

        }
    }
}