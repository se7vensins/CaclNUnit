using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CaclNUnit
{
   public static class Logger
   {
        private static void WriteEntry(string message, string type, string module)
        {
            Trace.WriteLine(string.Format(
                            "{0}, {1}, {2}, {3}",
                            DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                            type,
                            module,
                            message));
        }

        private static void WriteEntry(string message, string type, string module, int num)
        {
            Trace.WriteLine(string.Format(
                "{0}, {1}, {2}, {3}, {4}",
                   DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                            type,
                            module,
                            message,
                            num));
        }

        public static void Entry(string message, string module)
        {
            WriteEntry(message, "why" ,module);

        }
        public static void Result(string message, string module, int num)
        {
            WriteEntry("Finished", module, message,  num);
        }
   }
}
