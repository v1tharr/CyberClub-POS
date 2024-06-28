using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CyberClub_POS.View
{
   
    public partial class SbpWindow : Window
    {
        public SbpWindow()
        {
            InitializeComponent();
        }
        private void Window_MouseLeftButtonDown4(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Close_QR_btn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Min_QR_btn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

    }
}
