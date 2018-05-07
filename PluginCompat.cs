using SpigotGUI.Plugins;
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
    public partial class PluginCompat : Form
    {

        private Form1 form;
        private Style style;

        public PluginCompat(Form1 form)
        {
            this.form = form;
            InitializeComponent();
        }

        public void setStyle(Style style)
        {
            BackColor = style.getBackground();
            ForeColor = style.getText();

            this.style = style;
        }

            private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string value = (listBox1.SelectedItem + "");

            if (value.Equals("EmberGames"))
            {
                EmberGames pl = new EmberGames(form);
                pl.Visible = true;
                pl.setStyle(style);
            }
        }
    }
}
