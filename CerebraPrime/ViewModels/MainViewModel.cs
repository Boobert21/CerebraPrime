using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using CerebraPrime.Helpers;
using CerebraPrime.Pages;

namespace CerebraPrime.ViewModels
{
    public class MainViewModel
    {
        private readonly Frame _mainFrame;

        public ICommand ShowHomePageCommand { get; }
        public ICommand ShowOrderPageCommand { get; }
        public ICommand ShowSettingsPageCommand { get; }
        public ICommand ShowPlcPageCommand { get; }
        public ICommand ShowArchivePageCommand { get; }
        public ICommand ShowRealtimePageCommand { get; }

        public MainViewModel(Frame mainFrame)
        {
            _mainFrame = mainFrame;

            ShowHomePageCommand = new RelayCommand(ShowHomePage);
            ShowOrderPageCommand = new RelayCommand(ShowOrderPage);
            ShowSettingsPageCommand = new RelayCommand(ShowSettingsPage);
            ShowPlcPageCommand = new RelayCommand(ShowPlcPage);
            ShowArchivePageCommand = new RelayCommand(ShowArchivePage);
            ShowRealtimePageCommand = new RelayCommand(ShowRealtimePage);
        }

        private void ShowHomePage(object obj)
        {
            _mainFrame.Navigate(new MainPage());
        }

        private void ShowOrderPage(object obj)
        {
            _mainFrame.Navigate(new OrderPage()); // Убедитесь, что Page1 существует
        }

        private void ShowSettingsPage(object obj)
        {
            _mainFrame.Navigate(new SettingsPage()); // Убедитесь, что Page2 существует
        }
        private void ShowPlcPage(object obj)
        {
            _mainFrame.Navigate(new PlcPage()); // Убедитесь, что Page1 существует
        }

        private void ShowArchivePage(object obj)
        {
            _mainFrame.Navigate(new ArchivePage()); // Убедитесь, что Page2 существует
        }
        private void ShowRealtimePage(object obj)
        {
            _mainFrame.Navigate(new RealtimePage()); // Убедитесь, что Page1 существует
        }
    }
}
