using CyberClub_POS.View;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace CyberClub_POS.ViewModel
{
    //Реализаци открытия страниц через главное меню
    internal class MainViewModel : ViewModelBase
    {
        PosSystemDBEntities conn = new PosSystemDBEntities();
        private Page General = new GeneralPage();
        private Page Accounts = new AccountsPage();
        private Page Sales = new SalesPage();
        private Page Reports = new ReportsPage();
        private Page Storage = new StoragePage();
        private Page Settings = new SettingsPage();
        private Page _StartPage = new GeneralPage();

        public Page StartPage
        {
            get => _StartPage;
            set => Set(ref _StartPage, value); 
        }

        public ICommand OpenGrlPage
        {
            get
            {
                return new RelayCommand(() => StartPage = General);
            }
        }

        public ICommand OpenReportsPage
        {
            get
            {
                return new RelayCommand(() => StartPage = Reports);
            }   
        }

        public ICommand OpenAccountsPage
        {
            get
            {
                return new RelayCommand(() => StartPage = Accounts);
            }
        }
                public ICommand OpenSalesPage
        {
            get
            {
                return new RelayCommand(() => StartPage = Sales);
            }
        }
        public ICommand OpenStoragePage
        {
            get
            {
                return new RelayCommand(() => StartPage = Storage);
            }
        }

        public ICommand OpenSettingsPage
        {
            get
            {
                return new RelayCommand(() => StartPage = Settings);
            }
        }
    }
}
