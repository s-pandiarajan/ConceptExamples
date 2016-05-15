using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeletegateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactDetails contact = new ContactDetails()
            {
                Name = "Pandiarajan",
                EmailID = "pandi.rajan@gmail.com",
                ContactNumber = "9884089969",
                Feedback = "It is very good",
                Rating = 4                
            };

            EmailSender email = new EmailSender()
            {
                ToAddress = "Test@Test.com"
            };

            var emailSendDelegate = new ContactDetails.SendDetails(email.Send);
            contact.ReportSendDetailsStatus(emailSendDelegate);

            SMSSender sms = new SMSSender()
            {
                MobileNumber = "9884089969"
            };
            var smsSendDelegate = new ContactDetails.SendDetails(sms.Send);
            contact.ReportSendDetailsStatus(smsSendDelegate);


        }
    }
}
