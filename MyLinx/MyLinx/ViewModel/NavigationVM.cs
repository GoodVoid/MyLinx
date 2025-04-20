using MyLinx.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using MyLinx.View;
using MyLinx.Model;
using MahApps.Metro.IconPacks.Converter;

namespace MyLinx.ViewModel
{
    class NavigationVM : ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }
        public ICommand MinimizeCommand { get; }
        public ICommand CloseCommand { get; }
        public ICommand MainMenuCommand { get; set; }
        public ICommand MacrosCommand { get; set; }
        public ICommand ScriptsCommand { get; set; }
        public ICommand SettingsCommand { get; set; }


        //private void Macros(object obj) => CurrentView = new MacrosVM();
        private void MainMenu(object obj) => CurrentView = new MainWindowVM();
        private void Scripts(object obj) => CurrentView = new ScriptsVM();
        private void Macros(object obj) => CurrentView = new MacrosVM();
        private void Settings(object obj) => CurrentView = new SettingsVM();

        private void Minimize(object obj)
        {

            if (obj is Window window)
            {
                window.WindowState = WindowState.Minimized;
            }
        }
        private void Close(object obj)
        {
            ((Window)obj).Close();
        }

        public NavigationVM()
        {
            //MacrosCommand = new RelayCommand(Macros);
            MainMenuCommand = new RelayCommand(MainMenu);
            MinimizeCommand = new RelayCommand(Minimize);
            CloseCommand = new RelayCommand(Close);
            ScriptsCommand = new RelayCommand(Scripts);
            MacrosCommand = new RelayCommand(Macros);
            SettingsCommand = new RelayCommand(Settings);
            //начальная страница
            CurrentView = new MainWindowVM();
        }
    }
}
