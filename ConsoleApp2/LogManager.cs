using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class LogManager
    {
        public LogManager(Logger logger)
        {
           logger.logEvent += HandleLogEvent;
        }

        private void HandleLogEvent(object sender, LogEventArgs e)
        {
           
            Console.WriteLine($"Log message received: {e.Log}");
            
        }
    }
}
