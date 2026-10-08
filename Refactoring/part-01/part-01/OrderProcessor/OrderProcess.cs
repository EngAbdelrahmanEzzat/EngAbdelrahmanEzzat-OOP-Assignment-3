using System;
using System.Collections.Generic;
using System.Text;

namespace part_01.OrderProcessor
{
    public class OrderProcess
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IEmailSender _emailSender;
        public OrderProcess(IOrderRepository orderRepository, IEmailSender emailSender)
        {
            _orderRepository = orderRepository;
            _emailSender = emailSender;
        }
        public void Process(int orderId, string customerEmail)
        {
            _orderRepository.Save(orderId, DateTime.Now);
            _emailSender.Send(
                customerEmail,
                $"Order {orderId} confirmed at {DateTime.Now}");
        }


    }
}
