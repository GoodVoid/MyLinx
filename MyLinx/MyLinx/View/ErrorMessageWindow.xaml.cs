using MyLinx.ViewModel;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace MyLinx.View
{
    /// <summary>
    /// Логика взаимодействия для ErrorMessageWindow.xaml
    /// </summary>
    public partial class ErrorMessageWindow : Window
    {
        public ErrorMessageWindow() : this("Произошла ошибка")
        {

        }
        public ErrorMessageWindow(string errorMessage)
        {
            InitializeComponent();
            var viewModel = new ErrorWindowVM(errorMessage)
            {
                CloseAction = Close
            };

            DataContext = viewModel;
        }

        public static void ShowError(string errorMessage)
        {
            var window = new ErrorMessageWindow(errorMessage);
            window.ShowDialog();
        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
    }
}
