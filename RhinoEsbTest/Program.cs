using System;
using Common;
using Rhino.ServiceBus.Hosting;

namespace RhinoEsbTest
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueUtil.PrepareQueue("backend");

            Console.WriteLine("Backend: Starting to listen for incoming messages ...");

            var host = new DefaultHost();
            host.Start<BackendBootStrapper>();

            Console.ReadLine();
        }
    }
}
