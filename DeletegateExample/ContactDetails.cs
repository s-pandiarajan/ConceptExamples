using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeletegateExample
{
    public static class Status
    {
        public enum Result
        {
            SUCCESS = 0,
            FAILURE = 1
        }
    }
    public class ContactDetails
    {
        public string Name { get; set; }
        public string EmailID { get; set; }
        public string ContactNumber { get; set; }
        public string Information { get; set; }
        public string Feedback { get; set; }
        public double Rating { get; set; }

        public delegate Status.Result SendDetails(ContactDetails details);

        public override string ToString()
        {
            string strContact = "Name: " + Name +
                                "\tEmail: " + EmailID +
                                "\tContactNo: " + ContactNumber +
                                "\tInformation: " + Information +
                                "\tFeedback: " + Feedback +
                                "\tRating: " + Rating.ToString();
            return strContact;
        }

        public Status.Result ReportSendDetailsStatus(SendDetails sendContactDetails)
        {
            Status.Result status = sendContactDetails(this);
            if (status == Status.Result.SUCCESS)
            {
                Console.WriteLine("SUCCESS: Send Contact Details");
            }
            else
            {
                Console.WriteLine("FAILED: Send Contact Details");
            }
            return status;
        }
    }
}
