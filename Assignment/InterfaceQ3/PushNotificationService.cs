using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.InterfaceQ3
{
    internal class PushNotificationService : INotificationService
    {
        public void SendNotification(string message, string recipient)
        {
            Console.WriteLine($" Sending Push to {message}: {recipient}");

        }
    }
}
