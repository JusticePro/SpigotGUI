using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpigotGUI
{
    public partial class PlayerControl : Form

    {

        private string player;
        private Form1 form;

        public PlayerControl(string player, Form1 form)
        {
            this.player = player;
            this.form = form;
            InitializeComponent();
        }

        public void setStyle(Style style)
        {
            BackColor = style.getBackground();
            ForeColor = style.getText();

            // Groups

            groupBox1.BackColor = style.getGroup();
            groupBox2.BackColor = style.getGroup();
            groupBox3.BackColor = style.getGroup();
        }

        private void PlayerControl_Load(object sender, EventArgs e)
        {
            labelUser.Text = "Username: " + player;
            if (form.ips.ContainsKey(player))
            {
                labelIP.Text = "IP: " + form.ips[player];
            }
        }

        private void buttonKick_Click(object sender, EventArgs e)
        {
            form.sendCommand("kick " + player + " " + textBoxReason.Text);
        }

        private void buttonBan_Click(object sender, EventArgs e)
        {
            form.sendCommand("ban " + player + " " + textBoxReason.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.sendCommand("op " + player);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.sendCommand("deop " + player);
        }

        private void buttonPardon_Click(object sender, EventArgs e)
        {
            form.sendCommand("pardon " + player);
        }

        private void buttonBIP_Click(object sender, EventArgs e)
        {
            form.sendCommand("ban-ip " + player);
        }

        private void buttonPIP_Click(object sender, EventArgs e)
        {
            form.sendCommand("pardon-ip " + player);
        }
    }
}
