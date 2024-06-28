using System;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using System.IO;

namespace CyberClub_POS.View
{
    public partial class GeneralPage : Page
    {
        private string _username;
        private string _fullName;
        private DateTime _loginTime;
        private DispatcherTimer _timer;
        //Отображение логина, фио и таймера подсчета времени с момента авторизации
        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OperatorLogin.Content = value;
            }
        }

        public string FullName
        {
            get => _fullName;
            set
            {
                _fullName = value;
                OperatorFName.Content = value;
            }
        }

        public string WorkedHours { get; set; }

        public GeneralPage()
        {
            InitializeComponent();
            DataContext = this;
        }

        public void Initialize(string username, DateTime loginTime)
        {
            _username = username;
            _loginTime = loginTime;
            DisplayUserInfo();
            StartTimer();
        }

        // Перегрузка Initialize для совместимости
        public void Initialize(string username)
        {
            Initialize(username, DateTime.Now);
        }

        private void DisplayUserInfo()
        {
            using (PosSystemDBEntities conn = new PosSystemDBEntities())
            {
                var user = conn.Users.FirstOrDefault(u => u.Username == _username);
                if (user != null)
                {
                    FullName = user.FullName;
                    OperatorFName.Content = FullName;
                }
            }
        }

        private void StartTimer()
        {
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - _loginTime;
            WorkedHours = $"{elapsed.Hours}ч {elapsed.Minutes}м {elapsed.Seconds}с";
            WorkedHoursL.Content = WorkedHours;
        }

        private void HelpLink_Click(object sender, RoutedEventArgs e)
        {
            string pdfFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "cyberposclub_guide.pdf");

            if (File.Exists(pdfFilePath))
            {
                try
                {
                    Process.Start(new ProcessStartInfo(pdfFilePath) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось открыть PDF файл: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("PDF файл не найден: " + pdfFilePath);
            }
        }

        private void CyberX_site_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://cyberxcommunity.ru/clubs/barnaul/cyberx-barnaul.html") { UseShellExecute = true });
        }

        private void CyberX_VK_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://vk.com/cyberx_barnaul") { UseShellExecute = true });
        }

        private void Asiec_site_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.asiec.ru/") { UseShellExecute = true });
        }

        private void Me_GitHub_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/v1tharr/CyberClub_POS") { UseShellExecute = true });
        }
    }
}
