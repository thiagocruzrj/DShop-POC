using System;
using MassTransit;

namespace RecieveMessage
{
    public class SignIn
    {
        static void Main(string[] args)
        {
            var bus = Bus.Factory.CreateUsingRabbitMq(sbc =>
            {
                var host = sbc.Host(new Uri("rabbitmq://localhost"), h => {
                    h.Username("guest");
                    h.Password("guest");
                });

                sbc.RecieveEndpoint(host, "new_queue", ep =>{
                    ep.Consumer<MessageConsumer>();
                });
            });

            bus.Start();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            bus.Stop();
        }
    }
}