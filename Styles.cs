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
    public partial class Styles : Form
    {

        private Form1 form;

        public Styles(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.setStyle(Style.Spigot_Gui_Home);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.setStyle(Style.Spigot_Gui_Standard);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form.setStyle(Style.Spigot_Gui_Pro);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form.setStyle(Style.Spigot_Gui_Dark);
        }
    }
}
