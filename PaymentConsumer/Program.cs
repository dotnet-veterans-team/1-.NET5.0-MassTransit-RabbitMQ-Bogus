using GreenPipes;
using MassTransit;
using System;
using System.Threading.Tasks;
using WebApiPayments.Models;
using WebApiPayments.ViewModel;

namespace PaymentConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var bus = Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                cfg.Host(new Uri(RabbitMqSettings.RabbitMqRootUri), h =>
                {
                    h.Username(RabbitMqSettings.UserName);
                    h.Password(RabbitMqSettings.Password);
                });
                cfg.ReceiveEndpoint("PaymentsQueue", ep =>
                {
                    ep.PrefetchCount = 16;
                    ep.UseMessageRetry(r => r.Interval(2, 100));
                    ep.Consumer<PaymentsConsumerNotification>();
                });

            });

            bus.StartAsync();
            Console.WriteLine("Listening for Todo registered events.. Press enter to exit");
            Console.ReadLine();
            bus.StopAsync();
        }
    }

    public class PaymentsConsumerNotification : IConsumer<PaymentViewModel>
    {
        public async Task Consume(ConsumeContext<PaymentViewModel> context)
        {
            
            await Console.Out.WriteLineAsync($"Notification sent: Name: {context.Message.Name} - Amount: {context.Message.Amount}");
        }
    }
}
