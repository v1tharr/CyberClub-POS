using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using System.Windows.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CyberClub_POS.View
{
    public partial class GeneralPage : Page
    {
        private string _username;
        private string _fullName;
        private DateTime _loginTime;
        private DispatcherTimer _timer;

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
        
        public void Initialize(string username)
        {
            _username = username;
            _loginTime = DateTime.Now;
            DisplayUserInfo();
            StartTimer();
        }
        private void DisplayUserInfo()
        {
            using (PosSystemDBEntities conn = new PosSystemDBEntities())
            {
                var user = conn.Users.FirstOrDefault(u => u.Username == _username);
                if (user != null)
                {
                    FullName = user.FullName;
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
            string pdfPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "cyberposclub_guide.pdf");

            MessageBox.Show($"Path: {pdfPath}");

            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = pdfPath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть файл PDF: {ex.Message}");
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
