using System;
using System.Windows.Forms;
using Common;
using Rhino.ServiceBus;
using Rhino.ServiceBus.Hosting;

namespace WinClient1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()  
        {
            QueueUtil.PrepareQueue("winclient1");

            var host = new DefaultHost();
            host.BusConfiguration(c => c.Threads(1)
                                        .Retries(5)
                                        .Bus("rhino.queues://localhost:50002/WinClient1","winClient1")
                                        .Receive("Common", "rhino.queues://localhost:50001/RhinoEsbTest"));
            host.Start<ClientBootStrapper>();

            var bus = host.Bus as IServiceBus;


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(bus));
        }
    }
}
