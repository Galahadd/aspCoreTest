using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAppTest
{
    public class LogReader
    {

        public string Logs { get; set; }
        public DateTime OlsTarih { get; set; }
        public int LogAdet { get; set; }
    }

    public static class LoglarıListele
    {
        public static List<LogReader> Log()
        {
            List<LogReader> x = new List<LogReader>()
                {
                     new LogReader()
                    {
                   Logs ="21102019 logu",

                    }

                };
            return x.ToList();
        }


    }
    
}
