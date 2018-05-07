using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpigotGUI.Plugins
{
    public partial class EmberGames : Form
    {

        private Form1 form;

        public EmberGames(Form1 form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void EmberGames_Load(object sender, EventArgs e)
        {

        }

        public void setStyle(Style style)
        {
            BackColor = style.getBackground();
            ForeColor = style.getText();

            // Groups

            groupBox1.BackColor = style.getGroup();
        }

        private void buttonCoins_Click(object sender, EventArgs e)
        {
            if (textBoxPlayer.Text != "" && textBoxCoins.Text != "")
            {
                form.sendCommand("coin " + textBoxCoins.Text + " " + textBoxPlayer.Text);
                MessageBox.Show(this, "You set " + textBoxPlayer.Text + "'s coin amount to " + textBoxCoins.Text, "EmberGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show(this, "You can't have Player or Coins blank.", "EmberGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHeal_Click(object sender, EventArgs e)
        {
            if (textBoxPlayer.Text != "")
            {
                form.sendCommand("heal " + textBoxPlayer.Text);
                MessageBox.Show(this, "You healed " + textBoxPlayer.Text, "EmberGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "You can't have Player blank.", "EmberGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFeed_Click(object sender, EventArgs e)
        {
            if (textBoxPlayer.Text != "")
            {
                form.sendCommand("feed " + textBoxPlayer.Text);
                MessageBox.Show(this, "You fed " + textBoxPlayer.Text, "EmberGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "You can't have Player blank.", "EmberGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPlayer.Text != "" && textBoxReason.Text != "")
            {
                form.sendCommand("kick " + textBoxPlayer.Text + " " + textBoxReason.Text);
                MessageBox.Show(this, "You kicked " + textBoxPlayer.Text, "EmberGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "You can't have Player or Reason blank.", "EmberGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxPlayer.Text != "" && textBoxReason.Text != "")
            {
                form.sendCommand("ban " + textBoxPlayer.Text + " " + textBoxReason.Text);
                MessageBox.Show(this, "You banned " + textBoxPlayer.Text, "EmberGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "You can't have Player or Reason blank.", "EmberGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxPlayer.Text != "" && textBoxReason.Text != "")
            {
                form.sendCommand("warn " + textBoxPlayer.Text + " " + textBoxReason.Text);
                MessageBox.Show(this, "You warned " + textBoxPlayer.Text, "EmberGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "You can't have Player or Reason blank.", "EmberGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxPlayer.Text != "" && textBoxReason.Text != "")
            {
                form.sendCommand("mute " + textBoxPlayer.Text + " " + textBoxReason.Text);
                MessageBox.Show(this, "You muted " + textBoxPlayer.Text, "EmberGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "You can't have Player or Reason blank.", "EmberGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBoxPlayer.Text != "" && textBoxReason.Text != "")
            {
                form.sendCommand("unmute " + textBoxPlayer.Text + " " + textBoxReason.Text);
                MessageBox.Show(this, "You unmuted " + textBoxPlayer.Text, "EmberGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "You can't have Player or Reason blank.", "EmberGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxPlayer.Text != "" && textBoxReason.Text != "")
            {
                form.sendCommand("unban " + textBoxPlayer.Text + " " + textBoxReason.Text);
                MessageBox.Show(this, "You unbanned " + textBoxPlayer.Text, "EmberGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "You can't have Player or Reason blank.", "EmberGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxMsg.Text != "")
            {
                form.sendCommand("bc " + textBoxMsg.Text);
                MessageBox.Show(this, "You broadcasted message, \"" + textBoxMsg.Text + "\"", "EmberGames", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "You can't have Message blank.", "EmberGames", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
