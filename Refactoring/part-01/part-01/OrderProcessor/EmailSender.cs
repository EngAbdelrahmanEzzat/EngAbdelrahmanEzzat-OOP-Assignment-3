using System;
using System.Collections.Generic;
using System.Text;

namespace part_01.OrderProcessor
{
    public interface IOrderRepository
    {
        void Save(int orderId, DateTime processedAt);
    }
    public interface IEmailSender
    {
        void Send(string to, string body);
    }
    public class SqlOrderRepository : IOrderRepository
    {
        public void Save(int orderId, DateTime processedAt)
        {
            // Implementation to save order to SQL database
            Console.WriteLine($"[SQL] save order {orderId} @ {processedAt:O}");
        }

    }
    public class SmtpEmailSender : IEmailSender
    {
        public void Send(string to, string body)
        {
            // Implementation to send email via SMTP
            Console.WriteLine($"[SMTP] send email to {to} with body: {body}");
        }
    }
}
