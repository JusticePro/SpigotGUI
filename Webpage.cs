﻿using System;
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
    public partial class Webpage : Form
    {
        public Webpage(Uri site)
        {
            InitializeComponent();
            webBrowser1.Url = site;
            Text = site + " - Webviewer";
        }

        private void Webpage_Load(object sender, EventArgs e)
        {

        }
    }
}
