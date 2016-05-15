using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
    public class VisibleClock
    {
        public void SubscribeClock(Clock clk)
        {
            clk.TimeChangeEvent +=
                (sender, e) =>
                {
                    Console.WriteLine("{0}:{1}:{2}", e.Hour.ToString(), e.Minute.ToString(), e.Second.ToString());
                };
        }
    }
}
