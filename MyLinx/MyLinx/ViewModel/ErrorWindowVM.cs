using MyLinx.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyLinx.ViewModel
{
    public class ErrorWindowVM : ViewModelBase
    {
        private string _errorMessage;
        public string ErrorMessage
        {
            get => _errorMessage
                ; set
            {
                if (value != _errorMessage)
                {
                    _errorMessage = value;
                    OnPropertyChanged(nameof(ErrorMessage));
                }
            }
        }


        public ICommand CloseCommand { get; set; }

        public Action CloseAction { get; set; }

        public ErrorWindowVM() : this("Произошла ошибка") { }
        public ErrorWindowVM(string errorMessage)
        {

            ErrorMessage = errorMessage;
            CloseCommand = new RelayCommand(CloseWindow);
        }

        private void CloseWindow(object obj)
        {
            CloseAction?.Invoke();
        }

    }
}
