using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Logger
    {

        public event LogEventHandler logEvent;

        

        public void LogInAction(string log) {

            logEvent?.Invoke(this, new LogEventArgs(log));


         
        }
         


    }
}
