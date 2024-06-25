using HandyControl.Tools;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Input;

namespace CyberClub_POS.View
{
    public partial class UserManagementWindow : Window
    {
        public UserManagementWindow()
        {
            InitializeComponent();
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            ConfigHelper.Instance.SetLang("ru");
        }

        private void Window_MouseLeftButtonDown3(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void Close_UM_Btn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Minmize_UM_btn_Click (object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void AddNewUser_btn_clck(object sender, RoutedEventArgs e)
        {
            try
            {
                if (AddFName_TB == null || AddBdate == null || AddPhoneNum_TB == null)
                {
                    MessageBox.Show("Одно из полей является пустым.");
                    return;
                }

                if (string.IsNullOrEmpty(AddFName_TB.Text) ||
                    AddBdate.SelectedDate == null ||
                    string.IsNullOrEmpty(AddPhoneNum_TB.Text))
                {
                    MessageBox.Show("Все поля должны быть заполнены.");
                    return;
                }

                Users newUser = new Users
                {
                    FullName = AddFName_TB.Text,
                    BirthDate = AddBdate.SelectedDate.Value,
                    PhoneNumber = AddPhoneNum_TB.Text,
                    Role = "user",
                    Username = "defaultUserName",
                    Password = "defaultPassword"  
                };

                using (var dbContext = new PosSystemDBEntities())
                {
                    dbContext.Users.Add(newUser);
                    dbContext.SaveChanges();
                }

                MessageBox.Show("Пользователь успешно добавлен");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}\n{ex.StackTrace}");
            }
        }
    }
}
