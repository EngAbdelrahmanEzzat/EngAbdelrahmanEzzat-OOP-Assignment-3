using part_01.Notification;
using part_01.OrderProcessor;
using part_01.ShippingCalc;

namespace part_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            var aramexShipping = new ShippingCostCalculator(new Aramex());
            Console.WriteLine($"Aramex 2kg → {aramexShipping.Calculate(2)}");

            var fedExShipping = new ShippingCostCalculator(new FedEx());
            Console.WriteLine($"FedEx 2kg  → {fedExShipping.Calculate(2)}");

            Console.WriteLine();

           
            var orderProcessorCreator = new DefaultOrderProcessorCreator();
            orderProcessorCreator.Process(1001, "customer@example.com");

            Console.WriteLine();

            
            var urgentScheduledEmail =
                new ScheduledNotification(
                    new UrgentNotification(
                        new EmailNotification()))
                {
                    SendAt = DateTime.Today.AddHours(18)
                };

            urgentScheduledEmail.Send(
                "customer@example.com",
                "Your order ships tomorrow");

            var urgentSms =
                new UrgentNotification(
                    new SmsNotification());

            urgentSms.Send(
                "+201000000000",
                "OTP 4821");


            var urgentWhatsApp =
        new UrgentNotification(
        new WhatsAppNotification());

            urgentWhatsApp.Send(
                "+201000000000",
                "Your order ships tomorrow");





        }
    }
}
