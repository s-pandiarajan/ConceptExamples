using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeletegateExample
{
    public class SMSSender
    {
        public string MobileNumber { get; set; }

        public Status.Result Send(ContactDetails cd)
        {
            Console.WriteLine("SMS to" + MobileNumber + ":" + cd.ToString());
            return Status.Result.SUCCESS;
        }
    }
}
