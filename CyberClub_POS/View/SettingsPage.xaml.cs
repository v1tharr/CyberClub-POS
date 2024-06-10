using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using static CyberClub_POS.View.SettingsPage;
using System.Collections.ObjectModel;

namespace CyberClub_POS.View
{
    public partial class SettingsPage : Page
    {
        PosSystemDBEntities SettingsConn = new PosSystemDBEntities();
        private ObservableCollection<PriceStruct> PriceIDs;
        public SettingsPage()
        {
            InitializeComponent();
            LoadPrices();
        }

        public struct PriceStruct
        {
            public int PriceID { get; set; }
            public string CategoryID { get; set; }
            public string DayID { get; set; }
            public string PeriodID { get; set; }
            public decimal? Price { get; set; }
        }

        private void LoadPrices()
        {

            List<PriceStruct> PriceIDs = new List<PriceStruct>();
            var listPrices = SettingsConn.Prices.ToList();
            foreach (var item in listPrices)
            {
                PriceStruct priceStruct = new PriceStruct();

                var days = SettingsConn.Days.FirstOrDefault(c => c.DayID == item.DayID);
                priceStruct.DayID = days?.DayName;

                var period = SettingsConn.Periods.FirstOrDefault(c => c.PeriodID == item.PeriodID);
                priceStruct.PeriodID = period?.PeriodName;

                priceStruct.PriceID = item.PriceID;
                priceStruct.Price = item.Price;

                var category = SettingsConn.Categories.FirstOrDefault(c => c.CategoryID == item.CategoryID);
                priceStruct.CategoryID = category?.CategoryName;

                PriceIDs.Add(priceStruct);
            }
            Settings_DG.ItemsSource = PriceIDs;
        }

        private void UpdateSettings_btn_Click(object sender, RoutedEventArgs e)
        {
            LoadPrices();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PosSystemDBEntities SettingsConn = new PosSystemDBEntities();
            if (Settings_DG.SelectedItem != null)
            {
               var sett = (PriceStruct)Settings_DG.SelectedItem;
                Prices prices_chan = SettingsConn. Prices.FirstOrDefault(c=>c.PriceID==sett.PriceID);
                prices_chan.Price = sett.Price;
                SettingsConn.SaveChanges(); 
            }
            else
                MessageBox.Show("Выберите шаблон для просмотра", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            List<PriceStruct> PriceIDs = new List<PriceStruct>();
            var listPrices = SettingsConn.Prices.Where(p => p.CategoryID == 1).ToList();
            foreach (var item in listPrices)
            {
                PriceStruct priceStruct = new PriceStruct();

                var days = SettingsConn.Days.FirstOrDefault(c => c.DayID == item.DayID);
                priceStruct.DayID = days?.DayName;

                var period = SettingsConn.Periods.FirstOrDefault(c => c.PeriodID == item.PeriodID);
                priceStruct.PeriodID = period?.PeriodName;

                priceStruct.PriceID = item.PriceID;
                priceStruct.Price = item.Price;

                var category = SettingsConn.Categories.FirstOrDefault(c => c.CategoryID == item.CategoryID);
                priceStruct.CategoryID = category?.CategoryName;

                PriceIDs.Add(priceStruct);
            }
            Settings_DG.ItemsSource = PriceIDs;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            List<PriceStruct> PriceIDs = new List<PriceStruct>();
            var listPrices = SettingsConn.Prices.Where(p => p.CategoryID == 2).ToList();
            foreach (var item in listPrices)
            {
                PriceStruct priceStruct = new PriceStruct();

                var days = SettingsConn.Days.FirstOrDefault(c => c.DayID == item.DayID);
                priceStruct.DayID = days?.DayName;

                var period = SettingsConn.Periods.FirstOrDefault(c => c.PeriodID == item.PeriodID);
                priceStruct.PeriodID = period?.PeriodName;

                priceStruct.PriceID = item.PriceID;
                priceStruct.Price = item.Price;

                var category = SettingsConn.Categories.FirstOrDefault(c => c.CategoryID == item.CategoryID);
                priceStruct.CategoryID = category?.CategoryName;

                PriceIDs.Add(priceStruct);
            }
            Settings_DG.ItemsSource = PriceIDs;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            List<PriceStruct> PriceIDs = new List<PriceStruct>();
            var listPrices = SettingsConn.Prices.Where(p => p.CategoryID == 3).ToList();
            foreach (var item in listPrices)
            {
                PriceStruct priceStruct = new PriceStruct();

                var days = SettingsConn.Days.FirstOrDefault(c => c.DayID == item.DayID);
                priceStruct.DayID = days?.DayName;

                var period = SettingsConn.Periods.FirstOrDefault(c => c.PeriodID == item.PeriodID);
                priceStruct.PeriodID = period?.PeriodName;

                priceStruct.PriceID = item.PriceID;
                priceStruct.Price = item.Price;

                var category = SettingsConn.Categories.FirstOrDefault(c => c.CategoryID == item.CategoryID);
                priceStruct.CategoryID = category?.CategoryName;

                PriceIDs.Add(priceStruct);
            }
            Settings_DG.ItemsSource = PriceIDs;
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            List<PriceStruct> PriceIDs = new List<PriceStruct>();
            var listPrices = SettingsConn.Prices.Where(p => p.CategoryID == 4).ToList();
            foreach (var item in listPrices)
            {
                PriceStruct priceStruct = new PriceStruct();

                var days = SettingsConn.Days.FirstOrDefault(c => c.DayID == item.DayID);
                priceStruct.DayID = days?.DayName;

                var period = SettingsConn.Periods.FirstOrDefault(c => c.PeriodID == item.PeriodID);
                priceStruct.PeriodID = period?.PeriodName;

                priceStruct.PriceID = item.PriceID;
                priceStruct.Price = item.Price;

                var category = SettingsConn.Categories.FirstOrDefault(c => c.CategoryID == item.CategoryID);
                priceStruct.CategoryID = category?.CategoryName;

                PriceIDs.Add(priceStruct);
            }
            Settings_DG.ItemsSource = PriceIDs;
        }

        private void Update_RB(object sender, RoutedEventArgs e)
        {
            LoadPrices();
        }
    }
}
