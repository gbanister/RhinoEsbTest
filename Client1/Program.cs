using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using Rhino.ServiceBus.Hosting;

namespace Client1
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueUtil.PrepareQueue("client1");

            var host = new DefaultHost();
            host.Start<Client1BootStrapper>();


            Console.WriteLine("Client2: Waiting for message . . . ");

            Console.ReadLine();
        }
    }
}
