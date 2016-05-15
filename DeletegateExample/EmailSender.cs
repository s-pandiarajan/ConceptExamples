using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeletegateExample
{
    public class EmailSender
    {
        public string ToAddress { get; set; }
        public string CCAddress { get; set; }

        public Status.Result Send(ContactDetails cd)
        {
            Console.WriteLine("Email to: " + ToAddress + " : "+cd.ToString());
            return Status.Result.SUCCESS;
        }
    }
}
