using System;
using System.Collections.Generic;
using System.Text;

namespace part_01.Notification
{
    public interface INotification
    {
        void Send(string to, string message);
    }
    public class EmailNotification : INotification
    {
        public void Send(string to, string message) =>
            Console.WriteLine($"[email] {to}: {message}");
    }

    public class SmsNotification : INotification
    {
        public void Send(string to, string message) =>
            Console.WriteLine($"[sms] {to}: {message}");
    }

    public class UrgentNotification : INotification
    {
        private readonly INotification _notification;

        public UrgentNotification(INotification notification)
        {
            _notification = notification;
        }

        public void Send(string to, string message) =>
            _notification.Send(to, $"[URGENT] {message}");
    }

    public class ScheduledNotification : INotification
    {
        private readonly INotification _notification;

        public DateTime SendAt { get; set; }

        public ScheduledNotification(INotification notification)
        {
            _notification = notification;
        }

        public void Send(string to, string message) =>
            _notification.Send(to, message);
    }
}
