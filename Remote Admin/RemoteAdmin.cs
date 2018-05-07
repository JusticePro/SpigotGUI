using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpigotGUI
{
    public partial class RemoteAdmin : Form
    {

        private TcpClient client;

        public RemoteAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client = new TcpClient(textBoxHost.Text, RAServer.port);
            NetworkStream ns = client.GetStream();

            StreamWriter writer = new StreamWriter(ns);
            StreamReader reader = new StreamReader(ns);

            writer.WriteLine(textBoxPass.Text);
            writer.Flush();

            writer.WriteLine("msg&User connected to Remote Admin. Sent from client.");
            writer.Flush();

        }

        private void RemoteAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NetworkStream ns = client.GetStream();

            StreamWriter writer = new StreamWriter(ns);
            StreamReader reader = new StreamReader(ns);

            writer.WriteLine("cmd&say hi");
            writer.Flush();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            NetworkStream ns = client.GetStream();

            StreamWriter writer = new StreamWriter(ns);
            StreamReader reader = new StreamReader(ns);

            writer.WriteLine("cmd&" + textBoxCmd.Text);
            writer.Flush();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NetworkStream ns = client.GetStream();

            StreamWriter writer = new StreamWriter(ns);
            StreamReader reader = new StreamReader(ns);

            writer.WriteLine("msg&" + textBoxMsg.Text);
            writer.Flush();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            client.Close();
            Dispose();
        }
    }
}
