using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpigotGUI
{
    public partial class ConfigEditor : Form
    {
        public ConfigEditor()
        {
            InitializeComponent();
        }

        public ConfigEditor(string file)
        {
            InitializeComponent();

            Text = file + " - Config-Editor";

            string txt = "";

            foreach (string s in File.ReadAllLines(file))
            {
                txt = txt + s + "\n";
            }

            richTextBox1.Text = txt;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string file = saveFileDialog1.FileName;

                Text = file + " - Config-Editor";

                File.WriteAllLines(file, richTextBox1.Text.Split('\n'));
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result==DialogResult.OK)
            {
                string file = openFileDialog1.FileName;

                Text = file + " - Config-Editor";

                string txt = "";

                foreach (string s in File.ReadAllLines(file))
                {
                    txt = txt + s + "\n";
                }

                richTextBox1.Text = txt;
            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Text = "Untitled - Config-Editor";

            richTextBox1.Text = "";
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void stringArrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "array_name\n-  object1\n-  object2";
        }

        private void arrayObjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void arrayObjectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "-  object";
        }

        private void commandsymlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "command-block-overrides: []\naliases:\n    icanhasbukkit:\n    - \"version $1-\"";
        }

        private void commandsTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "    command_name:\n    - \"command1\"\n    - \"command2\"\n";
        }

        private void commandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "    - \"command\"";
        }

        private void commandymlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://bukkit.gamepedia.com/Commands.yml");
        }

        private void bukkitymlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://bukkit.gamepedia.com/Bukkit.yml");
        }

        private void pluginymlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://bukkit.gamepedia.com/Plugin_YAML");
        }

        private void permissionsymlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://bukkit.gamepedia.com/Permissions.yml");
        }

        private void helpymlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://bukkit.gamepedia.com/Help.yml");
        }

        private void bukkitWikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://bukkit.gamepedia.com/Main_Page");
        }
    }
}
