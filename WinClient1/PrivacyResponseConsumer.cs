using System;
using Common;
using Rhino.ServiceBus;

namespace WinClient1
{
    public class PrivacyResponseConsumer : ConsumerOf<PrivacyResponse>
    {
        public void Consume(PrivacyResponse message)
        {
            Console.WriteLine(message.Content);
        }
    }
}