using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinx.Model
{
  public class Macro
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Filepath { get; set; }
        public TimeSpan Createdate { get; set; }
    }
  public class Script
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public TimeSpan Createdate { get; set; }
    }
    public class Macrostatistic
    {
        public int Id { get; set; }
        public int macroid { get; set; }
        public int executioncount { get; set; }
    }
    public class Logs
    {
        public int Id { get; set; }
        public string Entitytype { get; set; }
        public int Entityid { get; set; }
        public double executiontime { get; set; }
        public DateTime executiondate { get; set; }
    }
    public class scriptStatistic
    {
        public int Id { get; set; }
        public int scriptid { get; set; }
        public int executioncount { get; set; }
    }
}
