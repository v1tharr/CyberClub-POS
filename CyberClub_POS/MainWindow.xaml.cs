using System;
using System.Windows;
using System.Windows.Input;
using System.Globalization;
using HandyControl.Tools;

namespace CyberClub_POS.View
{
    public partial class MainWindow : Window
    {
         PosSystemDBEntities conn = new PosSystemDBEntities();
        private string username;
        private GeneralPage _generalPage;
        public MainWindow(string username)
        {
            InitializeComponent();
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            ConfigHelper.Instance.SetLang("ru");
            PosSystemDBEntities conn = new PosSystemDBEntities();
            _generalPage = new GeneralPage();
            _generalPage.Initialize(username);
            MainFrame.Navigate(_generalPage);
            this.username = username;
        }
        private void MaxBtn_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
            }
            else
            {
                if (WindowState == WindowState.Maximized)
                {
                    WindowState = WindowState.Normal;
                }
            }
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_MouseLeftButtonDown2(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Exit_click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            this.Close();
        }

        private void MinBtn_Click2(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
