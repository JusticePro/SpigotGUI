using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpigotGUI.Remote_Admin
{
    class RAClientHandler
    {

        private TcpClient client;

        private Thread thread;
        private Form1 form;

        public RAClientHandler(TcpClient client, Form1 form)
        {
            this.client = client;
            this.form = form;
        }

        public void start()
        {
            thread = new Thread(() =>
            {
                while (client.Connected)
                {
                    NetworkStream ns = client.GetStream();

                    StreamWriter writer = new StreamWriter(ns);
                    StreamReader reader = new StreamReader(ns);

                    string s = reader.ReadLine();

                    if (s != null)
                    {
                        if (s.StartsWith("cmd&"))
                        {
                            form.sendCommand(s.Split('&')[1]);
                        }

                        if (s.StartsWith("msg&"))
                        {
                            MessageBox.Show(s.Split('&')[1]);
                        }
                    }

                }
            });
            thread.Start();
        }

    }
}
