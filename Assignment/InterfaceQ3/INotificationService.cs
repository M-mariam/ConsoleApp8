using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.InterfaceQ3
{
    internal interface INotificationService
    {
        void SendNotification(string recipient, string messange);
    }
}
