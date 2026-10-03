using System;
using System.Collections.Generic;
using System.Text;

namespace part_01.OrderProcessor
{
    public abstract class OrderProcessorCreator
    {
        public abstract OrderProcess Create();

        public void Process(int orderId, string customerEmail)
        {
            var processor = Create();
            processor.Process(orderId, customerEmail);
        }
    }
    public class DefaultOrderProcessorCreator : OrderProcessorCreator
    {
        public override OrderProcess Create()
        {
            return new OrderProcess(new SqlOrderRepository(), new SmtpEmailSender());
        }
    }
}
