using System;
using Common;
using Rhino.ServiceBus;

namespace RhinoEsbTest
{
    public class PrivacyMessageConsumer : ConsumerOf<PrivacyMessage>
    {
        private readonly IServiceBus _serviceBus;

        public PrivacyMessageConsumer(IServiceBus serviceBus)
        {
            _serviceBus = serviceBus;
        }

        public void Consume(PrivacyMessage message)
        {
            Console.WriteLine(message.Content);

            _serviceBus.Publish(new PrivacyResponse
            {
                Content = message.Content
            });

            //_serviceBus.Publish(new MessageWithoutSubscriber());
            //_serviceBus.Notify(new MessageWithoutSubscriber());
        }
    }
}