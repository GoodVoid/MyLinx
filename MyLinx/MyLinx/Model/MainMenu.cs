using Dapper;
using MyLinx.View;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace MyLinx.Model
{
    class MainMenu
    {
        string MacrosNum;
        public string GetMacrosNumb()
        {
            var DbCon = new DatabaseConnection();

            DbCon.Open();
            string sql = "SELECT * FROM Macros";
            var macrosList = DbCon.Connection.Query<Macro>(sql).ToList();
            MacrosNum = macrosList.Count().ToString();
            return MacrosNum;
        }
        

        
    }
}
