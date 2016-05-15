using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clk = new Clock();

            VisibleClock vclk = new VisibleClock();
            vclk.SubscribeClock(clk);

            Logger log = new Logger();
            log.SubscribeClock(clk);

            clk.RunClock();
        }
    }
}
