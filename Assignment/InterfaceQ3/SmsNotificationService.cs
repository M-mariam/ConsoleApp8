using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.InterfaceQ3
{
    internal class SmsNotificationService : INotificationService
    {
        public void SendNotification(string message, string recipient)
        {
            Console.WriteLine($" Sending SMS to {message}: {recipient}");

        }
    }
}
