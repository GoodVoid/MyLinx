using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinx.Model
{
    public static class Global
    {
        public static readonly DateTime StartTime = DateTime.Now;

        public static TimeSpan GetElapsed()
        {
            return DateTime.Now - StartTime;
        }
    }
}
