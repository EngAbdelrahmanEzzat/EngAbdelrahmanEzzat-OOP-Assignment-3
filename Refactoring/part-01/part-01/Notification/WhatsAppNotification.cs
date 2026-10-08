using System;
using System.Collections.Generic;
using System.Text;

namespace part_01.Notification
{
    public class WhatsAppNotification : INotification
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"[whatsapp] {to}: {message}");
        }
    }
}
