using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.ObjectModel;

namespace CyberClub_POS.View
{

    public partial class AccountsPage : Page
    {
        PosSystemDBEntities connaccs = new PosSystemDBEntities();
        public AccountsPage()
        {
            InitializeComponent();
            LoadAccounts();
        }
        public class SaleWithUser
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
        //Для отображения исходных данных, что передают айдишники
        private void LoadAccounts()
        {
            var salesWithUsers = from sale in connaccs.Sales
                                 join user in connaccs.Users on sale.UserID equals user.UserID
                                 join pricecat in connaccs.Prices on sale.PriceID equals pricecat.PriceID
                                 join product in connaccs.Products on sale.ProductID equals product.ProductID
                                 join category in connaccs.Categories on pricecat.CategoryID equals category.CategoryID
                                 select new SaleWithUser
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

            AccountsDG.ItemsSource = salesWithUsers.ToList();
        }

        private void UpdateAccounts_Click(object sender, RoutedEventArgs e)
        {
            LoadAccounts();
        }

        private void DeleteRow_btn_Click(object sender, RoutedEventArgs e)
        {

            connaccs = new PosSystemDBEntities();
            if (AccountsDG.SelectedItems != null && AccountsDG.SelectedItems.Count > 0)
            {
                var toRemove = AccountsDG.SelectedItems.Cast<SaleWithUser>().ToList();
                foreach (var sales in toRemove)
                {
                    var salesInDB = connaccs.Sales.Find(sales.SaleID);
                    if (salesInDB != null)
                    {
                        connaccs.Sales.Remove(salesInDB);
                    }
                }
                connaccs.SaveChanges();
            }
        }
      
    }
}
