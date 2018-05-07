using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpigotGUI
{
    public partial class Form1 : Form
    {

        private Server server;
        private RAServer rserver;

        private string jarLoc;

        public Dictionary<string, string> ips = new Dictionary<string, string>();

        private Style style;

        public Form1()
        {
            InitializeComponent();
            if (Program.edition.Equals(Edition.Professional))
            {
                if (File.Exists("style.spigotgui"))
                {
                    string s = File.ReadAllText("style.spigotgui");

                    if (s.Equals(Style.Spigot_Gui_Home.name))
                    {
                        setStyle(Style.Spigot_Gui_Home);
                    }

                    if (s.Equals(Style.Spigot_Gui_Standard.name))
                    {
                        setStyle(Style.Spigot_Gui_Standard);
                    }

                    if (s.Equals(Style.Spigot_Gui_Pro.name))
                    {
                        setStyle(Style.Spigot_Gui_Pro);
                    }

                    if (s.Equals(Style.Spigot_Gui_Dark.name))
                    {
                        setStyle(Style.Spigot_Gui_Dark);
                    }

                }
            }
        }

        public void sendCommand(string cmd)
        {
            if (server != null)
            {
                server.sendCommand(cmd);
            }
        }

        public void setStyle(Style style)
        {
            BackColor = style.getBackground();
            ForeColor = style.getText();

            // Groups
            consoleGroup.BackColor = style.getGroup();
            serverControl.BackColor = style.getGroup();
            ssramGroup.BackColor = style.getGroup();
            sscustomGroup.BackColor = style.getGroup();
            raserverGroup.BackColor = style.getGroup();
            raclientGroup.BackColor = style.getGroup();

            // Panels
            generalPage.BackColor = style.getPanel();
            propertiesPage.BackColor = style.getPanel();
            playersPage.BackColor = style.getPanel();
            ssPage.BackColor = style.getPanel();
            configPage.BackColor = style.getPanel();
            pluginsPage.BackColor = style.getPanel();
            licencePage.BackColor = style.getPanel();
            raPage.BackColor = style.getPanel();

            this.style = style;

            File.WriteAllText("style.spigotgui", style.name);
            
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello", "Yo");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                ipLabel.Text = "IP Address: Hidden";
            }else
            {
                ipLabel.Text = "IP Address: " + GetLocalIPAddress();
            }
        }


        private void startServer_Click(object sender, EventArgs e)
        {
            if (server == null)
            {
                if (jarLoc != null)
                {
                    server = new Server(jarLoc, "", this);
                    server.start();
                    MessageBox.Show(this, "Server is now online.", "SpigotGUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Jar Location not set.", "SpigotGUI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }else
            {
                if (jarLoc != null)
                {
                    server = new Server(jarLoc, "", this);
                    server.start();
                    MessageBox.Show(this, "Server is now online.", "SpigotGUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Jar Location not set.", "SpigotGUI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void stopServer_Click(object sender, EventArgs e)
        {
            if (server != null)
            {
                if (jarLoc != null)
                {
                    server.stop();
                    MessageBox.Show(this, "Server is now offline.", "SpigotGUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Jar Location not set.", "SpigotGUI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void loadJarBTN_Click(object sender, EventArgs e)
        {
            DialogResult r = openFileDialog1.ShowDialog();

            if (r==DialogResult.OK)
            {
                jarLoc = openFileDialog1.FileName;
                MessageBox.Show(this, "Set jar location to " + jarLoc, "SpigotGUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                jarLocLabel.Text = "Jar Loc: " + jarLoc;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendCommandBTN_Click(object sender, EventArgs e)
        {
            if (server != null)
            {
                if (executeSayCMD.Checked)
                {
                    server.sendCommand("say " + textBox1.Text);
                    textBox1.Text = "";
                }else
                {
                    server.sendCommand(textBox1.Text);
                    textBox1.Text = "";
                }
            }else
            {
                MessageBox.Show(this, "Server is offline.", "SpigotGUI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void consoleField_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            consoleField.SelectionStart = consoleField.Text.Length;
            // scroll it automatically
            consoleField.ScrollToCaret();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelLicence.Text = "Licence: " + Program.edition;
            textBoxSerial.Text = Program.getSerialNumber() + "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBoxPlayer.Text != "")
            {
                PlayerControl form = new PlayerControl(textBoxPlayer.Text, this);
                form.Visible = true;
                form.setStyle(style);
            }else
            {
                MessageBox.Show(this, "Player Selection is empty.", "SpigotGUI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }


        public void onAddConsole(string text)
        {
            try
            {
                if (text.Contains("lost connection: "))
                {
                    string player = text.Substring("[08:27:43 INFO]: ".Length).Split(' ')[0];
                    string reason = text.Substring("[08:27:43 INFO]: ".Length).Split(':')[1].Split(' ')[1];
                    onPlayerLeave(player, reason);
                }
                
                if (text.Contains("logged in with entity id"))
                {

                    string player = text.Substring("[08:27:43 INFO]: ".Length).Split('[')[0];
                    string ip = text.Substring("[08:27:43 INFO]: ".Length).Split(']')[0].Split('/')[1].Split(':')[0];
                    string port = text.Substring("[08:27:43 INFO]: ".Length).Split(']')[0].Split('/')[1].Split(':')[1];

                    onPlayerJoin(player, ip, port);
                }
            }catch (Exception e)
            {
                
            }
        }

        public void onPlayerJoin(string player, string ip, string port)
        {
            ips.Add(player, ip);
        }

        public void onPlayerLeave(string player, string reason)
        {
            
        }

        private void trackBarRMax_Scroll(object sender, EventArgs e)
        {
            labelRMax.Text = "Maximum-Ram: " + trackBarRMax.Value + "MB";
        }

        private void trackBarRMin_Scroll(object sender, EventArgs e)
        {
            labelRMin.Text = "Minimum-Ram: " + trackBarRMin.Value + "MB";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelSSCmd.Text = "Command: \"java -Xmx" + trackBarRMax.Value + "M -Xms" + trackBarRMin.Value + "M " + textBoxSwitch.Text + " \"" + jarLoc + "\" " + textBoxArgs.Text + "\"";
        }

        private void buttonSStart_Click(object sender, EventArgs e)
        {
            if (jarLoc != null)
            {
                if (trackBarRMin.Value > trackBarRMax.Value)
                {
                    MessageBox.Show(this, "Minimum Ram cannot be larger then Maximum Ram.", "SpigotGUI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (trackBarRMax.Value > 4000 && !Program.edition.Equals(Edition.Professional))
                    {
                        MessageBox.Show(this, "Maximum Ram can't be over 4000 MegaBytes unless you have professional.", "SpigotGUI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    server = new Server(jarLoc, "-Xmx" + trackBarRMax.Value + "M -Xms" + trackBarRMin.Value + "M " + textBoxSwitch.Text + " \"" + jarLoc + "\" " + textBoxArgs.Text, this);
                    server.start();
                    MessageBox.Show(this, "Server is now online.", "SpigotGUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }else
            {
                MessageBox.Show(this, "Jar location not set.", "SpigotGUI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void executeSayCMD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConfigEditor ce = new ConfigEditor();
            ce.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Webpage page = new Webpage(new Uri("http://dev.bukkit.org/bukkit-plugins"));
            page.Visible = true;
            page.Text = "Bukkit Plugins";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Webpage page = new Webpage(new Uri("http://www.spigotmc.org/resources/"));
            page.Visible = true;
            page.Text = "Spigot Plugins";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(this);

            if (result==DialogResult.OK)
            {
                string path = openFileDialog1.FileName;

                File.Copy(path, "plugins\\" + openFileDialog1.SafeFileName);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;

                File.Delete(path);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Program.edition.Equals(Edition.Professional))
            {
                PluginCompat pl = new PluginCompat(this);
                pl.Visible = true;
                pl.setStyle(style);
            }else
            {
                MessageBox.Show(this, "Professional Only Feature.", "SpigotGUI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[4];
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (File.Exists("server.properties"))
            {
                ConfigEditor editor = new ConfigEditor("server.properties");
                editor.Visible = true;
            }else
            {
                MessageBox.Show(this, "Server Settings file does not exist.", "SpigotGUI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (File.Exists("whitelist.json"))
            {
                ConfigEditor editor = new ConfigEditor("whitelist.json");
                editor.Visible = true;
            }
            else
            {
                MessageBox.Show(this, "Whitelist file does not exist.", "SpigotGUI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (File.Exists("ops.json"))
            {
                ConfigEditor editor = new ConfigEditor("ops.json");
                editor.Visible = true;
            }
            else
            {
                MessageBox.Show(this, "OP's file does not exist.", "SpigotGUI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (File.Exists("banned-players.json"))
            {
                ConfigEditor editor = new ConfigEditor("banned-players.json");
                editor.Visible = true;
            }
            else
            {
                MessageBox.Show(this, "Banned-Players file does not exist.", "SpigotGUI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (File.Exists("banned-ips.json"))
            {
                ConfigEditor editor = new ConfigEditor("banned-ips.json");
                editor.Visible = true;
            }
            else
            {
                MessageBox.Show(this, "Banned-IPs file does not exist.", "SpigotGUI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBoxACode.Text.Equals(Program.getProfessionalEdition(Program.getSerialNumber()) + ""))
            {
                Program.edition = Edition.Professional;
                labelLicence.Text = "Licence: " + Program.edition;
                MessageBox.Show(this, "You have upgraded to Professional Edition.", "SpigotGUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                File.WriteAllText("licence.spigotgui", textBoxACode.Text);
            } else
            {
                MessageBox.Show(this, "Activation Code is not valid.", "SpigotGUI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (Program.edition.Equals(Edition.Professional))
            {
                if (rserver != null)
                {
                    rserver.stop();
                    rserver = new RAServer(textBoxPass.Text, this);
                    rserver.start();
                }
                else
                {
                    rserver = new RAServer(textBoxPass.Text, this);
                    rserver.start();
                }
            }else
            {
                MessageBox.Show(this, "Professional Only Feature.", "SpigotGUI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            RemoteAdmin admin = new RemoteAdmin();
            admin.Visible = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (rserver != null)
            {
                rserver.stop();
            }
        }

        private void checkBoxShowPS_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxShowPS.Checked)
            {
                textBoxPass.PasswordChar = '*';
            }else
            {
                textBoxPass.PasswordChar = '\0';
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (Program.edition.Equals(Edition.Professional))
            {
                Styles s = new Styles(this);
                s.Visible = true;
            }else
            {
                MessageBox.Show(this, "Professional Only Feature.", "SpigotGUI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rserver != null)
            {
                if (rserver.thread != null)
                {
                    if (rserver.thread.IsAlive)
                    {
                        e.Cancel = true;
                        MessageBox.Show("You must stop your Remote Admin Server first.");
                    }
                }
            }
        }
    }
}
