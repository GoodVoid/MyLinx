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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyLinx.View
{
    /// <summary>
    /// Логика взаимодействия для Macros.xaml
    /// </summary>
    public partial class Macros : UserControl
    {
        public Macros()
        {
            InitializeComponent();
        }

        private void Open(object sender, RoutedEventArgs e)
        {
            ErrorMessageWindow.ShowError(SearchTxtBox.Text);
        }
    }
}
