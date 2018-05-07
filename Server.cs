using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpigotGUI
{
    class Server
    {

        private Process process;

        private string path, arguments;
        private Form1 form;

        public Server(string path, string args, Form1 form)
        {
            this.path = path;
            this.arguments = args;
            this.form = form;
        }

        public void start()
        {
            char quote = '"';
            ProcessStartInfo ServerStartInfo = new ProcessStartInfo(@"java.exe",
                @"-Xms1024m -Xmx2048m -jar " + quote + path + quote + "");
            process = new Process();

            process.StartInfo = ServerStartInfo;

            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;

            // Set event handler
            process.OutputDataReceived += onReceiveData;

            // Start the process.
            process.Start();


            // Start the asynchronous read
            process.BeginOutputReadLine();

        }

        public void stop()
        {
            sendCommand("stop");
        }

        public void sendCommand(string cmd)
        {
            StreamWriter writer = process.StandardInput;
            writer.WriteLine(cmd);
        }

        delegate void SetTextCallback(string text);

        private void setText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (form.consoleField.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setText);
                form.consoleField.Invoke(d, new object[] { text });
            }
            else
            {
                form.consoleField.Text = text;
            }
        }

        private string console = "";

        private void addText(string text)
        {
            console = console + text + "\n";
            setText(console);
            form.onAddConsole(text);
        }

        public void onReceiveData(object sender, DataReceivedEventArgs e)
        {
            addText(e.Data);
        }

    }
}
