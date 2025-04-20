using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLinx.Model;
using MyLinx.Tools;
using MyLinx.View;

namespace MyLinx.ViewModel
{
    class MacrosVM : Tools.ViewModelBase
    {
        private string _searchTxt;


        public string SearchText
        {
            get => _searchTxt;

            set
            {
                if (value != _searchTxt)
                {
                    _searchTxt = value;
                    OnPropertyChanged(nameof(SearchText));
                }
            }
        }

        public ObservableCollection<MacroItem> MacroItems { get; set; } = new();

        public MacrosVM()
        {
            LoadFromDatabase();
        }

        private void LoadFromDatabase()
        {
            // Пример: заглушка. Здесь должен быть код доступа к БД.
            MacroItems.Add(new MacroItem { Title = "Автокликер", Description = "Нажимает каждые 2 секунды" });
            MacroItems.Add(new MacroItem { Title = "Открытие приложения", Description = "Открывает блокнот в 9:00" });
        }




    }
}
