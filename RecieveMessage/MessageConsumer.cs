using System;
using System.Threading.Tasks;
using MassTransit;

namespace RecieveMessage
{
    public class MessageConsumer : IConsumer<Message>
    {
        public async Task Consume(ConsumeContext<Message> context)
        {
            await Console.Out.WriteLineAsync($"Received: {context.Message.Name}");
        }
    }
}