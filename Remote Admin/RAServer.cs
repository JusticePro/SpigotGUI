using SpigotGUI.Remote_Admin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpigotGUI
{
    class RAServer
    {

        public static int port = 545;

        private string password;
        private Form1 form;

        private TcpListener listener;

        private bool running = true;

        public Thread thread;

        public RAServer(string password, Form1 form)
        {
            this.password = password;
            this.form = form;
        }

        public void run()
        {
            listener = new TcpListener(port);
            listener.Start();
            listener.Server.ReceiveTimeout = 1000;
            listener.Server.SendTimeout = 1000;
            while (running)
            {
                TcpClient client = null;
                try
                {
                    client = listener.AcceptTcpClient();
                }
                catch (SocketException e)
                {
                    break;
                }
                
                NetworkStream ns = client.GetStream();

                StreamWriter writer = new StreamWriter(ns);
                StreamReader reader = new StreamReader(ns);

                /* Auth */
                string s = reader.ReadLine();
                if (s != null)
                {
                    if (!s.Equals(password))
                    {
                        client.Close();
                    }
                }

                RAClientHandler ch = new RAClientHandler(client, form);
                ch.start();
            }
            close();
        }

        public void start()
        {
            thread = getThread();
            thread.Start();
        }

        public void stop()
        {
            running = false;
            TcpClient c = new TcpClient("localhost", port);
            c.Close();
            thread.Abort();
        }

        public void close()
        {
            listener.Stop();
        }

        public Thread getThread()
        {
            return new Thread(new ThreadStart(run));
        }

    }
}