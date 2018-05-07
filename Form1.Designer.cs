using System;
using System.Net;
using System.Net.Sockets;

namespace SpigotGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serverControl = new System.Windows.Forms.GroupBox();
            this.startServer = new System.Windows.Forms.Button();
            this.stopServer = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.generalPage = new System.Windows.Forms.TabPage();
            this.consoleGroup = new System.Windows.Forms.GroupBox();
            this.sendCommandBTN = new System.Windows.Forms.Button();
            this.executeSayCMD = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.consoleField = new System.Windows.Forms.RichTextBox();
            this.propertiesPage = new System.Windows.Forms.TabPage();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.playersPage = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxPlayer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ssPage = new System.Windows.Forms.TabPage();
            this.buttonSStart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelSSCmd = new System.Windows.Forms.Label();
            this.sscustomGroup = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSwitch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxArgs = new System.Windows.Forms.TextBox();
            this.ssramGroup = new System.Windows.Forms.GroupBox();
            this.labelRMax = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.trackBarRMax = new System.Windows.Forms.TrackBar();
            this.labelRMin = new System.Windows.Forms.Label();
            this.trackBarRMin = new System.Windows.Forms.TrackBar();
            this.configPage = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pluginsPage = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.licencePage = new System.Windows.Forms.TabPage();
            this.button16 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxACode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSerial = new System.Windows.Forms.TextBox();
            this.raPage = new System.Windows.Forms.TabPage();
            this.raclientGroup = new System.Windows.Forms.GroupBox();
            this.button19 = new System.Windows.Forms.Button();
            this.raserverGroup = new System.Windows.Forms.GroupBox();
            this.checkBoxShowPS = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.ipLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.loadJarBTN = new System.Windows.Forms.Button();
            this.jarLocLabel = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.spigotGUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.startServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button9 = new System.Windows.Forms.Button();
            this.labelLicence = new System.Windows.Forms.Label();
            this.button20 = new System.Windows.Forms.Button();
            this.serverControl.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.generalPage.SuspendLayout();
            this.consoleGroup.SuspendLayout();
            this.propertiesPage.SuspendLayout();
            this.playersPage.SuspendLayout();
            this.ssPage.SuspendLayout();
            this.sscustomGroup.SuspendLayout();
            this.ssramGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRMin)).BeginInit();
            this.configPage.SuspendLayout();
            this.pluginsPage.SuspendLayout();
            this.licencePage.SuspendLayout();
            this.raPage.SuspendLayout();
            this.raclientGroup.SuspendLayout();
            this.raserverGroup.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverControl
            // 
            this.serverControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(49)))));
            this.serverControl.Controls.Add(this.startServer);
            this.serverControl.Controls.Add(this.stopServer);
            this.serverControl.Location = new System.Drawing.Point(417, 6);
            this.serverControl.Name = "serverControl";
            this.serverControl.Size = new System.Drawing.Size(171, 243);
            this.serverControl.TabIndex = 3;
            this.serverControl.TabStop = false;
            this.serverControl.Text = "Quick Server Controls";
            // 
            // startServer
            // 
            this.startServer.Location = new System.Drawing.Point(6, 19);
            this.startServer.Name = "startServer";
            this.startServer.Size = new System.Drawing.Size(75, 23);
            this.startServer.TabIndex = 2;
            this.startServer.Text = "Start Server";
            this.startServer.UseVisualStyleBackColor = true;
            this.startServer.Click += new System.EventHandler(this.startServer_Click);
            // 
            // stopServer
            // 
            this.stopServer.Location = new System.Drawing.Point(87, 19);
            this.stopServer.Name = "stopServer";
            this.stopServer.Size = new System.Drawing.Size(75, 23);
            this.stopServer.TabIndex = 1;
            this.stopServer.Text = "Stop Server";
            this.stopServer.UseVisualStyleBackColor = true;
            this.stopServer.Click += new System.EventHandler(this.stopServer_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.generalPage);
            this.tabControl1.Controls.Add(this.propertiesPage);
            this.tabControl1.Controls.Add(this.playersPage);
            this.tabControl1.Controls.Add(this.ssPage);
            this.tabControl1.Controls.Add(this.configPage);
            this.tabControl1.Controls.Add(this.pluginsPage);
            this.tabControl1.Controls.Add(this.licencePage);
            this.tabControl1.Controls.Add(this.raPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 369);
            this.tabControl1.TabIndex = 5;
            // 
            // generalPage
            // 
            this.generalPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(49)))));
            this.generalPage.Controls.Add(this.consoleGroup);
            this.generalPage.Controls.Add(this.serverControl);
            this.generalPage.Location = new System.Drawing.Point(4, 22);
            this.generalPage.Name = "generalPage";
            this.generalPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalPage.Size = new System.Drawing.Size(768, 343);
            this.generalPage.TabIndex = 0;
            this.generalPage.Text = "General";
            // 
            // consoleGroup
            // 
            this.consoleGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(49)))));
            this.consoleGroup.Controls.Add(this.sendCommandBTN);
            this.consoleGroup.Controls.Add(this.executeSayCMD);
            this.consoleGroup.Controls.Add(this.textBox1);
            this.consoleGroup.Controls.Add(this.consoleField);
            this.consoleGroup.Location = new System.Drawing.Point(6, 6);
            this.consoleGroup.Name = "consoleGroup";
            this.consoleGroup.Size = new System.Drawing.Size(392, 243);
            this.consoleGroup.TabIndex = 4;
            this.consoleGroup.TabStop = false;
            this.consoleGroup.Text = "Console";
            // 
            // sendCommandBTN
            // 
            this.sendCommandBTN.Location = new System.Drawing.Point(286, 211);
            this.sendCommandBTN.Name = "sendCommandBTN";
            this.sendCommandBTN.Size = new System.Drawing.Size(97, 23);
            this.sendCommandBTN.TabIndex = 3;
            this.sendCommandBTN.Text = "Send Command";
            this.sendCommandBTN.UseVisualStyleBackColor = true;
            this.sendCommandBTN.Click += new System.EventHandler(this.sendCommandBTN_Click);
            // 
            // executeSayCMD
            // 
            this.executeSayCMD.AutoSize = true;
            this.executeSayCMD.Location = new System.Drawing.Point(7, 215);
            this.executeSayCMD.Name = "executeSayCMD";
            this.executeSayCMD.Size = new System.Drawing.Size(137, 17);
            this.executeSayCMD.TabIndex = 2;
            this.executeSayCMD.Text = "Execute /say with input";
            this.executeSayCMD.UseVisualStyleBackColor = true;
            this.executeSayCMD.CheckedChanged += new System.EventHandler(this.executeSayCMD_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(383, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // consoleField
            // 
            this.consoleField.Location = new System.Drawing.Point(0, 19);
            this.consoleField.Name = "consoleField";
            this.consoleField.ReadOnly = true;
            this.consoleField.Size = new System.Drawing.Size(383, 163);
            this.consoleField.TabIndex = 0;
            this.consoleField.Text = "";
            this.consoleField.TextChanged += new System.EventHandler(this.consoleField_TextChanged);
            // 
            // propertiesPage
            // 
            this.propertiesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(49)))));
            this.propertiesPage.Controls.Add(this.button15);
            this.propertiesPage.Controls.Add(this.button14);
            this.propertiesPage.Controls.Add(this.button13);
            this.propertiesPage.Controls.Add(this.button12);
            this.propertiesPage.Controls.Add(this.button11);
            this.propertiesPage.Controls.Add(this.button10);
            this.propertiesPage.Location = new System.Drawing.Point(4, 22);
            this.propertiesPage.Name = "propertiesPage";
            this.propertiesPage.Padding = new System.Windows.Forms.Padding(3);
            this.propertiesPage.Size = new System.Drawing.Size(768, 343);
            this.propertiesPage.TabIndex = 1;
            this.propertiesPage.Text = "Properties";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(6, 317);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(756, 23);
            this.button15.TabIndex = 5;
            this.button15.Text = "Config Page";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(550, 6);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(130, 23);
            this.button14.TabIndex = 4;
            this.button14.Text = "Banned IP\'s";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(414, 6);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(130, 23);
            this.button13.TabIndex = 3;
            this.button13.Text = "Banned Players";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(278, 6);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(130, 23);
            this.button12.TabIndex = 2;
            this.button12.Text = "Operators";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(142, 6);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(130, 23);
            this.button11.TabIndex = 1;
            this.button11.Text = "Whitelist";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 6);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(130, 23);
            this.button10.TabIndex = 0;
            this.button10.Text = "Server Settings";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // playersPage
            // 
            this.playersPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(49)))));
            this.playersPage.Controls.Add(this.label14);
            this.playersPage.Controls.Add(this.textBoxPlayer);
            this.playersPage.Controls.Add(this.button1);
            this.playersPage.Location = new System.Drawing.Point(4, 22);
            this.playersPage.Name = "playersPage";
            this.playersPage.Padding = new System.Windows.Forms.Padding(3);
            this.playersPage.Size = new System.Drawing.Size(768, 343);
            this.playersPage.TabIndex = 2;
            this.playersPage.Text = "Players";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(380, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Player Control Panel, It is an tool connected to SpigotGUI for managing players.";
            // 
            // textBoxPlayer
            // 
            this.textBoxPlayer.Location = new System.Drawing.Point(154, 316);
            this.textBoxPlayer.Name = "textBoxPlayer";
            this.textBoxPlayer.Size = new System.Drawing.Size(608, 20);
            this.textBoxPlayer.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Player Control Panel:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ssPage
            // 
            this.ssPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(49)))));
            this.ssPage.Controls.Add(this.buttonSStart);
            this.ssPage.Controls.Add(this.button2);
            this.ssPage.Controls.Add(this.labelSSCmd);
            this.ssPage.Controls.Add(this.sscustomGroup);
            this.ssPage.Controls.Add(this.ssramGroup);
            this.ssPage.Location = new System.Drawing.Point(4, 22);
            this.ssPage.Name = "ssPage";
            this.ssPage.Padding = new System.Windows.Forms.Padding(3);
            this.ssPage.Size = new System.Drawing.Size(768, 343);
            this.ssPage.TabIndex = 3;
            this.ssPage.Text = "SuperStart";
            // 
            // buttonSStart
            // 
            this.buttonSStart.Location = new System.Drawing.Point(665, 314);
            this.buttonSStart.Name = "buttonSStart";
            this.buttonSStart.Size = new System.Drawing.Size(75, 23);
            this.buttonSStart.TabIndex = 10;
            this.buttonSStart.Text = "Start Server";
            this.buttonSStart.UseVisualStyleBackColor = true;
            this.buttonSStart.Click += new System.EventHandler(this.buttonSStart_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Generate Command";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelSSCmd
            // 
            this.labelSSCmd.AutoSize = true;
            this.labelSSCmd.Location = new System.Drawing.Point(6, 3);
            this.labelSSCmd.Name = "labelSSCmd";
            this.labelSSCmd.Size = new System.Drawing.Size(70, 13);
            this.labelSSCmd.TabIndex = 8;
            this.labelSSCmd.Text = "Command: \"\"";
            // 
            // sscustomGroup
            // 
            this.sscustomGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(49)))));
            this.sscustomGroup.Controls.Add(this.label12);
            this.sscustomGroup.Controls.Add(this.textBoxSwitch);
            this.sscustomGroup.Controls.Add(this.label10);
            this.sscustomGroup.Controls.Add(this.textBoxArgs);
            this.sscustomGroup.Location = new System.Drawing.Point(325, 128);
            this.sscustomGroup.Name = "sscustomGroup";
            this.sscustomGroup.Size = new System.Drawing.Size(313, 212);
            this.sscustomGroup.TabIndex = 7;
            this.sscustomGroup.TabStop = false;
            this.sscustomGroup.Text = "Custom";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Custom Switches:";
            // 
            // textBoxSwitch
            // 
            this.textBoxSwitch.Location = new System.Drawing.Point(111, 42);
            this.textBoxSwitch.Name = "textBoxSwitch";
            this.textBoxSwitch.Size = new System.Drawing.Size(188, 20);
            this.textBoxSwitch.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Custom Arguments:";
            // 
            // textBoxArgs
            // 
            this.textBoxArgs.Location = new System.Drawing.Point(111, 16);
            this.textBoxArgs.Name = "textBoxArgs";
            this.textBoxArgs.Size = new System.Drawing.Size(188, 20);
            this.textBoxArgs.TabIndex = 7;
            // 
            // ssramGroup
            // 
            this.ssramGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(49)))));
            this.ssramGroup.Controls.Add(this.labelRMax);
            this.ssramGroup.Controls.Add(this.label11);
            this.ssramGroup.Controls.Add(this.label13);
            this.ssramGroup.Controls.Add(this.trackBarRMax);
            this.ssramGroup.Controls.Add(this.labelRMin);
            this.ssramGroup.Controls.Add(this.trackBarRMin);
            this.ssramGroup.Location = new System.Drawing.Point(6, 128);
            this.ssramGroup.Name = "ssramGroup";
            this.ssramGroup.Size = new System.Drawing.Size(313, 212);
            this.ssramGroup.TabIndex = 6;
            this.ssramGroup.TabStop = false;
            this.ssramGroup.Text = "Ram";
            // 
            // labelRMax
            // 
            this.labelRMax.AutoSize = true;
            this.labelRMax.Location = new System.Drawing.Point(6, 16);
            this.labelRMax.Name = "labelRMax";
            this.labelRMax.Size = new System.Drawing.Size(104, 13);
            this.labelRMax.TabIndex = 1;
            this.labelRMax.Text = "Maximum-Ram: 0MB";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Maximum-Ram";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Minimum-Ram";
            // 
            // trackBarRMax
            // 
            this.trackBarRMax.Location = new System.Drawing.Point(9, 105);
            this.trackBarRMax.Maximum = 8000;
            this.trackBarRMax.Name = "trackBarRMax";
            this.trackBarRMax.Size = new System.Drawing.Size(268, 45);
            this.trackBarRMax.TabIndex = 0;
            this.trackBarRMax.Scroll += new System.EventHandler(this.trackBarRMax_Scroll);
            // 
            // labelRMin
            // 
            this.labelRMin.AutoSize = true;
            this.labelRMin.Location = new System.Drawing.Point(6, 40);
            this.labelRMin.Name = "labelRMin";
            this.labelRMin.Size = new System.Drawing.Size(101, 13);
            this.labelRMin.TabIndex = 3;
            this.labelRMin.Text = "Minimum-Ram: 0MB";
            // 
            // trackBarRMin
            // 
            this.trackBarRMin.Location = new System.Drawing.Point(9, 169);
            this.trackBarRMin.Maximum = 8000;
            this.trackBarRMin.Name = "trackBarRMin";
            this.trackBarRMin.Size = new System.Drawing.Size(268, 45);
            this.trackBarRMin.TabIndex = 4;
            this.trackBarRMin.Scroll += new System.EventHandler(this.trackBarRMin_Scroll);
            // 
            // configPage
            // 
            this.configPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(49)))));
            this.configPage.Controls.Add(this.label15);
            this.configPage.Controls.Add(this.button3);
            this.configPage.Location = new System.Drawing.Point(4, 22);
            this.configPage.Name = "configPage";
            this.configPage.Padding = new System.Windows.Forms.Padding(3);
            this.configPage.Size = new System.Drawing.Size(768, 343);
            this.configPage.TabIndex = 4;
            this.configPage.Text = "Config-Editor";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(578, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "The Config Editor is intended for .yml or any file. It can be used for any file b" +
    "ut it is created with the intent of using yml files.";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(756, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Start Config Editor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pluginsPage
            // 
            this.pluginsPage.AutoScroll = true;
            this.pluginsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(49)))));
            this.pluginsPage.Controls.Add(this.button8);
            this.pluginsPage.Controls.Add(this.button7);
            this.pluginsPage.Controls.Add(this.button6);
            this.pluginsPage.Controls.Add(this.button5);
            this.pluginsPage.Controls.Add(this.button4);
            this.pluginsPage.Location = new System.Drawing.Point(4, 22);
            this.pluginsPage.Name = "pluginsPage";
            this.pluginsPage.Padding = new System.Windows.Forms.Padding(3);
            this.pluginsPage.Size = new System.Drawing.Size(768, 343);
            this.pluginsPage.TabIndex = 5;
            this.pluginsPage.Text = "Plugins";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(214, 7);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(112, 23);
            this.button8.TabIndex = 4;
            this.button8.Text = "Plugin Compatibility";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(104, 7);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(104, 23);
            this.button7.TabIndex = 3;
            this.button7.Text = "Delete Plugin";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(633, 35);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(129, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "Get Spigot Plugins";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(633, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Get Bukkit Plugins";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Import Plugin";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // licencePage
            // 
            this.licencePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(49)))));
            this.licencePage.Controls.Add(this.button16);
            this.licencePage.Controls.Add(this.label2);
            this.licencePage.Controls.Add(this.textBoxACode);
            this.licencePage.Controls.Add(this.label1);
            this.licencePage.Controls.Add(this.textBoxSerial);
            this.licencePage.Location = new System.Drawing.Point(4, 22);
            this.licencePage.Name = "licencePage";
            this.licencePage.Padding = new System.Windows.Forms.Padding(3);
            this.licencePage.Size = new System.Drawing.Size(768, 343);
            this.licencePage.TabIndex = 6;
            this.licencePage.Text = "Licences";
            this.licencePage.Click += new System.EventHandler(this.tabPage6_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(687, 314);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 4;
            this.button16.Text = "Activate";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Activation Code:";
            // 
            // textBoxACode
            // 
            this.textBoxACode.Location = new System.Drawing.Point(97, 32);
            this.textBoxACode.Name = "textBoxACode";
            this.textBoxACode.Size = new System.Drawing.Size(205, 20);
            this.textBoxACode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serial Number:";
            // 
            // textBoxSerial
            // 
            this.textBoxSerial.Location = new System.Drawing.Point(85, 6);
            this.textBoxSerial.Name = "textBoxSerial";
            this.textBoxSerial.ReadOnly = true;
            this.textBoxSerial.Size = new System.Drawing.Size(166, 20);
            this.textBoxSerial.TabIndex = 0;
            // 
            // raPage
            // 
            this.raPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(49)))));
            this.raPage.Controls.Add(this.raclientGroup);
            this.raPage.Controls.Add(this.raserverGroup);
            this.raPage.Location = new System.Drawing.Point(4, 22);
            this.raPage.Name = "raPage";
            this.raPage.Padding = new System.Windows.Forms.Padding(3);
            this.raPage.Size = new System.Drawing.Size(768, 343);
            this.raPage.TabIndex = 7;
            this.raPage.Text = "Remote Admin";
            // 
            // raclientGroup
            // 
            this.raclientGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(49)))));
            this.raclientGroup.Controls.Add(this.button19);
            this.raclientGroup.Location = new System.Drawing.Point(6, 6);
            this.raclientGroup.Name = "raclientGroup";
            this.raclientGroup.Size = new System.Drawing.Size(200, 331);
            this.raclientGroup.TabIndex = 1;
            this.raclientGroup.TabStop = false;
            this.raclientGroup.Text = "Client";
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(6, 19);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 23);
            this.button19.TabIndex = 0;
            this.button19.Text = "Connect";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // raserverGroup
            // 
            this.raserverGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(49)))));
            this.raserverGroup.Controls.Add(this.checkBoxShowPS);
            this.raserverGroup.Controls.Add(this.label3);
            this.raserverGroup.Controls.Add(this.textBoxPass);
            this.raserverGroup.Controls.Add(this.button18);
            this.raserverGroup.Controls.Add(this.button17);
            this.raserverGroup.Location = new System.Drawing.Point(562, 6);
            this.raserverGroup.Name = "raserverGroup";
            this.raserverGroup.Size = new System.Drawing.Size(200, 331);
            this.raserverGroup.TabIndex = 0;
            this.raserverGroup.TabStop = false;
            this.raserverGroup.Text = "Server";
            // 
            // checkBoxShowPS
            // 
            this.checkBoxShowPS.AutoSize = true;
            this.checkBoxShowPS.Location = new System.Drawing.Point(6, 269);
            this.checkBoxShowPS.Name = "checkBoxShowPS";
            this.checkBoxShowPS.Size = new System.Drawing.Size(102, 17);
            this.checkBoxShowPS.TabIndex = 4;
            this.checkBoxShowPS.Text = "Show Password";
            this.checkBoxShowPS.UseVisualStyleBackColor = true;
            this.checkBoxShowPS.CheckedChanged += new System.EventHandler(this.checkBoxShowPS_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(6, 305);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(188, 20);
            this.textBoxPass.TabIndex = 2;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(119, 19);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 1;
            this.button18.Text = "Stop Server";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(6, 19);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 0;
            this.button17.Text = "Start Server";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(16, 13);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(98, 13);
            this.ipLabel.TabIndex = 6;
            this.ipLabel.Text = "IP Address: Hidden";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(681, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Show IP Address";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.CheckFileExists = false;
            this.openFileDialog1.FileName = "Server";
            this.openFileDialog1.Filter = "Minecraft Server (*.jar)|*.jar";
            // 
            // loadJarBTN
            // 
            this.loadJarBTN.Location = new System.Drawing.Point(681, 47);
            this.loadJarBTN.Name = "loadJarBTN";
            this.loadJarBTN.Size = new System.Drawing.Size(107, 23);
            this.loadJarBTN.TabIndex = 5;
            this.loadJarBTN.Text = "Load Jar";
            this.loadJarBTN.UseVisualStyleBackColor = true;
            this.loadJarBTN.Click += new System.EventHandler(this.loadJarBTN_Click);
            // 
            // jarLocLabel
            // 
            this.jarLocLabel.AutoSize = true;
            this.jarLocLabel.Location = new System.Drawing.Point(16, 30);
            this.jarLocLabel.Name = "jarLocLabel";
            this.jarLocLabel.Size = new System.Drawing.Size(74, 13);
            this.jarLocLabel.TabIndex = 8;
            this.jarLocLabel.Text = "Jar Loc: None";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SpigotGUI";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spigotGUIToolStripMenuItem,
            this.toolStripMenuItem2,
            this.startServerToolStripMenuItem,
            this.stopServerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 92);
            // 
            // spigotGUIToolStripMenuItem
            // 
            this.spigotGUIToolStripMenuItem.Name = "spigotGUIToolStripMenuItem";
            this.spigotGUIToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.spigotGUIToolStripMenuItem.Text = "SpigotGUI";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem2.Text = " ";
            // 
            // startServerToolStripMenuItem
            // 
            this.startServerToolStripMenuItem.Name = "startServerToolStripMenuItem";
            this.startServerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.startServerToolStripMenuItem.Text = "Start Server";
            // 
            // stopServerToolStripMenuItem
            // 
            this.stopServerToolStripMenuItem.Name = "stopServerToolStripMenuItem";
            this.stopServerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.stopServerToolStripMenuItem.Text = "Stop Server";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(600, 47);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "About";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // labelLicence
            // 
            this.labelLicence.AutoSize = true;
            this.labelLicence.Location = new System.Drawing.Point(170, 13);
            this.labelLicence.Name = "labelLicence";
            this.labelLicence.Size = new System.Drawing.Size(97, 13);
            this.labelLicence.TabIndex = 10;
            this.labelLicence.Text = "Licence: Unknown";
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(519, 47);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 23);
            this.button20.TabIndex = 11;
            this.button20.Text = "Styles";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(3)))));
            this.ClientSize = new System.Drawing.Size(800, 429);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.labelLicence);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.jarLocLabel);
            this.Controls.Add(this.loadJarBTN);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SpigotGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.serverControl.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.consoleGroup.ResumeLayout(false);
            this.consoleGroup.PerformLayout();
            this.propertiesPage.ResumeLayout(false);
            this.playersPage.ResumeLayout(false);
            this.playersPage.PerformLayout();
            this.ssPage.ResumeLayout(false);
            this.ssPage.PerformLayout();
            this.sscustomGroup.ResumeLayout(false);
            this.sscustomGroup.PerformLayout();
            this.ssramGroup.ResumeLayout(false);
            this.ssramGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRMin)).EndInit();
            this.configPage.ResumeLayout(false);
            this.configPage.PerformLayout();
            this.pluginsPage.ResumeLayout(false);
            this.licencePage.ResumeLayout(false);
            this.licencePage.PerformLayout();
            this.raPage.ResumeLayout(false);
            this.raclientGroup.ResumeLayout(false);
            this.raserverGroup.ResumeLayout(false);
            this.raserverGroup.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        #endregion
        private System.Windows.Forms.Button stopServer;
        private System.Windows.Forms.Button startServer;
        private System.Windows.Forms.GroupBox serverControl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage generalPage;
        private System.Windows.Forms.TabPage propertiesPage;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox consoleGroup;
        public System.Windows.Forms.RichTextBox consoleField;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox executeSayCMD;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button loadJarBTN;
        private System.Windows.Forms.Label jarLocLabel;
        private System.Windows.Forms.Button sendCommandBTN;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TabPage playersPage;
        private System.Windows.Forms.TextBox textBoxPlayer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spigotGUIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.TabPage ssPage;
        private System.Windows.Forms.Label labelRMax;
        private System.Windows.Forms.TrackBar trackBarRMax;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelRMin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TrackBar trackBarRMin;
        private System.Windows.Forms.GroupBox ssramGroup;
        private System.Windows.Forms.GroupBox sscustomGroup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxArgs;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSwitch;
        private System.Windows.Forms.Label labelSSCmd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonSStart;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage configPage;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage pluginsPage;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label labelLicence;
        private System.Windows.Forms.TabPage licencePage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSerial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxACode;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TabPage raPage;
        private System.Windows.Forms.GroupBox raclientGroup;
        private System.Windows.Forms.GroupBox raserverGroup;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.CheckBox checkBoxShowPS;
        private System.Windows.Forms.Button button20;
    }
}

