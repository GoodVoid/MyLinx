using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinx.ViewModel
{
    class ScriptsVM : Tools.ViewModelBase
    {
        private string _searchText;
        
        public string SearchText
        {
            get => _searchText;

            set
            {
                if (value != _searchText)
                {
                    _searchText = value;
                    OnPropertyChanged(nameof(SearchText));
                }
            }
        }
        
        
        public ScriptsVM()
        {
            

        }

    }
}
