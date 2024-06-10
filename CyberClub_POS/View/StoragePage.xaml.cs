using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Collections.Specialized;
using CyberClub_POS.ViewModel;

namespace CyberClub_POS.View
{
    public partial class StoragePage : Page
    {
        private PosSystemDBEntities _StorageTable;


        public StoragePage()
        {
            InitializeComponent();
            //StorageDG.ItemsSource = GetData();
            LoadProducts();
        }

        private void LoadProducts()
        {
            _StorageTable = new PosSystemDBEntities();
            StorageDG.ItemsSource = _StorageTable.Products.ToList();
        }

        public System.Windows.Controls.DataGridSelectionMode SelectionMode { get; set; }

        private void SearchBar_Storage_DG_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            _StorageTable = new PosSystemDBEntities();
            StorageDG.ItemsSource = _StorageTable.Products.Where(C => C.ProductName.Contains(SearchBar_Storage_DG.Text) ||
                C.ProdCategory.ToString().Contains(SearchBar_Storage_DG.Text) ||
                C.Price.ToString().Contains(SearchBar_Storage_DG.Text)).ToList();
        }

        private void Add_Products_btn_Click(object sender, RoutedEventArgs e)
        {
            ManageProductAdd manageProductAdd = new ManageProductAdd();
            manageProductAdd.Show();
        }

        private void DeleteRow_btn_Click(object sender, RoutedEventArgs e)
        {

            _StorageTable = new PosSystemDBEntities();
            if (StorageDG.SelectedItems != null && StorageDG.SelectedItems.Count > 0)
            {
                var toRemove = StorageDG.SelectedItems.Cast<Products>().ToList();
                foreach (var product in toRemove)
                {
                    var productInDb = _StorageTable.Products.Find(product.ProductID);
                    if (productInDb != null)
                    {
                        _StorageTable.Products.Remove(productInDb);
                    }
                }

                _StorageTable.SaveChanges();

                StorageDG.ItemsSource = _StorageTable.Products.ToList();

            }
        }
        private void EditRow_btn_Click(object sender, RoutedEventArgs e)
        {
            _StorageTable.SaveChanges();
            StorageDG.ItemsSource = new ObservableCollection<Products>(_StorageTable.Products.ToList());
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            var dg = (DataGrid)sender;
            if (dg == null || dg.ItemsSource == null) return;

            var sourceCollection = dg.ItemsSource as ObservableCollection<Products>;
            if (sourceCollection == null) return;

            sourceCollection.CollectionChanged += DataGrid_CollectionChanged;
        }
        private void DataGrid_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            _StorageTable.SaveChanges();
        }
        private void Update_DG_btn_Click(object sender, EventArgs e) 
        {
            _StorageTable = new PosSystemDBEntities();
            StorageDG.ItemsSource = _StorageTable.Products.ToList();
         }
        private void AllSelect_on(object sender, RoutedEventArgs e)
        {


        }
        private void AllSelect_off(object sender, RoutedEventArgs e)
        {

        }

        //    private List<Item> GetData()
        //    {
        //        return new List<Item>
        //    {
        //        new Item { IsSelected = false, Name = "Item 1" },
        //        new Item { IsSelected = false, Name = "Item 2" },
        //        new Item { IsSelected = false, Name = "Item 3" }
        //    };
        //    }

        //    private void SelectAll_Checked(object sender, RoutedEventArgs e)
        //    {
        //        SetAllCheckBoxes(true);
        //    }

        //    private void SelectAll_Unchecked(object sender, RoutedEventArgs e)
        //    {
        //        SetAllCheckBoxes(false);
        //    }

        //    private void SetAllCheckBoxes(bool isChecked)
        //    {
        //        foreach (var item in StorageDG.ItemsSource)
        //        {
        //            var dataItem = item as Item;
        //            if (dataItem != null)
        //            {
        //                dataItem.IsSelected = isChecked;
        //            }
        //        }

        //        StorageDG.Items.Refresh();
        //    }
        //}

        //public class Item : INotifyPropertyChanged
        //{
        //    private bool _isSelected;
        //    public bool IsSelected
        //    {
        //        get => _isSelected;
        //        set
        //        {
        //            _isSelected = value;
        //            OnPropertyChanged(nameof(IsSelected));
        //        }
        //    }

        //    public string Name { get; set; }

        //    public event PropertyChangedEventHandler PropertyChanged;

        //    protected void OnPropertyChanged(string propertyName)
        //    {
        //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}
    }
}


