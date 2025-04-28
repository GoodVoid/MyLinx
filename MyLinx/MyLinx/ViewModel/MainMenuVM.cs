using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Util;
using System.Windows.Navigation;
using MyLinx.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Threading;

namespace MyLinx.ViewModel
{
    class MainMenuVM: Tools.ViewModelBase
    {
        
        private DispatcherTimer _timer;
        private string _elapsedTime;

        public string ElapsedTime
        {
            get => _elapsedTime;
            set
            {
                _elapsedTime = value;
                OnPropertyChanged();
            }
        }
        private string _macrosNumb;

        public string MacrosNumb
        {
            get => _macrosNumb;
            set
            {
                _macrosNumb = value;
                OnPropertyChanged();
            }
        }
        public MainMenuVM()
        {
            var MM = new MainMenu();
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += Timer_Tick;
            _timer.Start();

            MacrosNumb = MM.GetMacrosNumb();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = Global.GetElapsed();
            ElapsedTime = elapsed.ToString(@"hh\:mm\:ss");
        }


        
    }
}
