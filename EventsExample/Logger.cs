using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
    public class Logger
    {
        public void SubscribeClock(Clock clk)
        {
            clk.TimeChangeEvent += new Clock.TimeChangeHandler(NewTime);
        }

        public void NewTime(object clock, TimeEventArgs e)
        {
            Console.WriteLine("Logging Event when {0}:{1}:{2}", e.Hour.ToString(), e.Minute.ToString(), e.Second.ToString());
        }
    }
}
