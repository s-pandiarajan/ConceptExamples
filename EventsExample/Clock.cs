using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsExample
{
    public class Clock
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public delegate void TimeChangeHandler(object clock, TimeEventArgs eventArgs);
        public event TimeChangeHandler TimeChangeEvent;

        public void RunClock()
        {
            while(true)
            {
                Thread.Sleep(100);
                if( DateTime.Now.Second != Second )
                {
                    TimeEventArgs e = new TimeEventArgs
                    {
                        Hour = DateTime.Now.Hour,
                        Minute = DateTime.Now.Minute,
                        Second = DateTime.Now.Second
                    };
                    if(TimeChangeEvent != null)
                        TimeChangeEvent(this, e);
                }
                Hour = DateTime.Now.Hour; Minute = DateTime.Now.Minute; Second = DateTime.Now.Second;
            }
        }
    }

    public class TimeEventArgs : EventArgs
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
    }
}
