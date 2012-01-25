using System;
using Common;
using Rhino.ServiceBus;

namespace Client1
{
    public class HelloWorldResponseConsumer : ConsumerOf<PrivacyResponse>
    {
        public void Consume(PrivacyResponse message)
        {
            Console.WriteLine(message.Content);
        }
    }
}