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

namespace CyberClub_POS.View
{
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            PosSystemDBEntities conn = new PosSystemDBEntities();
            string Login;
            Users select = conn.Users.Where(c => c.Username == txtUser.Text && c.Password == txtPass.Password).FirstOrDefault();
            if (String.IsNullOrWhiteSpace(txtUser.Text) || String.IsNullOrWhiteSpace(txtPass.Password))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (select != null)
            {
                if (txtUser.Text == select.Username && txtPass.Password == select.Password && select.Role == "admin")
                {
                    string role = select.Role;
                    this.Hide();
                    MainWindow mainwindow1 = new MainWindow(txtUser.Text);
                    mainwindow1.ShowDialog();
                }
            }
            else MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
