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
using System.Windows.Shapes;

namespace CyberClub_POS.View
{

    public partial class ManageProductAdd : Window
    {
        PosSystemDBEntities _AddStorage = new PosSystemDBEntities();
        public ManageProductAdd()
        {
            InitializeComponent();
        }
        private void Window_MouseLeftButtonDown5(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Close_ProductAddition_Btn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Minmize_ProductAddition_btn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void SaveAddedStorage_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (AddPName_TB == null || AddCategory_TB == null || AddPrice_TB == null || AddQuantity_TB == null)
                {
                    MessageBox.Show("Одно из текстовых полей является null.");
                    return;
                }

                Products AddProducts = new Products();
                if (!string.IsNullOrEmpty(AddPName_TB.Text) &&
                    !string.IsNullOrEmpty(AddCategory_TB.Text) &&
                    !string.IsNullOrEmpty(AddPrice_TB.Text) &&
                    !string.IsNullOrEmpty(AddQuantity_TB.Text))
                {
                    AddProducts.ProductName = AddPName_TB.Text;
                    AddProducts.ProdCategory = AddCategory_TB.Text;

                    if (decimal.TryParse(AddPrice_TB.Text, out decimal price))
                    {
                        AddProducts.Price = price;
                    }
                    else
                    {
                        MessageBox.Show("Введите корректное значение для цены.");
                        return;
                    }

                    if (int.TryParse(AddQuantity_TB.Text, out int quantity))
                    {
                        AddProducts.AvailableQuantity = quantity;
                    }
                    else
                    {
                        MessageBox.Show("Введите корректное значение для количества.");
                        return;
                    }

                    _AddStorage.Products.Add(AddProducts);
                    _AddStorage.SaveChanges();
                    MessageBox.Show("Продукты успешно добавлены");

                    AddPName_TB.Text = string.Empty;
                    AddCategory_TB.Text = string.Empty;
                    AddPrice_TB.Text = string.Empty;
                    AddQuantity_TB.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Все поля должны быть заполнены.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}\n{ex.StackTrace}");
            }
        }

    }
}
