using System;
using System.Windows.Forms;
using Common;
using Rhino.ServiceBus;

namespace WinClient1
{
    public partial class Form1 : Form
    {
        private readonly IServiceBus _bus;

        public Form1(IServiceBus bus)
        {
            _bus = bus;
            InitializeComponent();

            textBox1.Text = "foo";
            textBox2.Text = "bar";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _bus.Send(new PrivacyMessage {Content = "privacy-on"});
        }

    }
}
