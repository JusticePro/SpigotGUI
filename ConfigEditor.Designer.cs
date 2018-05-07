namespace SpigotGUI
{
    partial class ConfigEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigEditor));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringArrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrayObjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandsTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandsymlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandymlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginymlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bukkitymlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permissionsymlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpymlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bukkitWikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 411);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Config File (*.yml)|*.yml|All files|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Config File (*.yml)|*.yml|All files|*.*";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stringArrayToolStripMenuItem,
            this.commandsToolStripMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.insertToolStripMenuItem.Text = "Insert";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // stringArrayToolStripMenuItem
            // 
            this.stringArrayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrayObjectToolStripMenuItem1});
            this.stringArrayToolStripMenuItem.Name = "stringArrayToolStripMenuItem";
            this.stringArrayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stringArrayToolStripMenuItem.Text = "String Array";
            this.stringArrayToolStripMenuItem.Click += new System.EventHandler(this.stringArrayToolStripMenuItem_Click);
            // 
            // arrayObjectToolStripMenuItem1
            // 
            this.arrayObjectToolStripMenuItem1.Name = "arrayObjectToolStripMenuItem1";
            this.arrayObjectToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.arrayObjectToolStripMenuItem1.Text = "Array Object";
            this.arrayObjectToolStripMenuItem1.Click += new System.EventHandler(this.arrayObjectToolStripMenuItem1_Click);
            // 
            // commandsToolStripMenuItem
            // 
            this.commandsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandsymlToolStripMenuItem,
            this.commandsTemplateToolStripMenuItem,
            this.commandToolStripMenuItem});
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            this.commandsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.commandsToolStripMenuItem.Text = "Commands";
            // 
            // commandsTemplateToolStripMenuItem
            // 
            this.commandsTemplateToolStripMenuItem.Name = "commandsTemplateToolStripMenuItem";
            this.commandsTemplateToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.commandsTemplateToolStripMenuItem.Text = "Command Template";
            this.commandsTemplateToolStripMenuItem.Click += new System.EventHandler(this.commandsTemplateToolStripMenuItem_Click);
            // 
            // commandsymlToolStripMenuItem
            // 
            this.commandsymlToolStripMenuItem.Name = "commandsymlToolStripMenuItem";
            this.commandsymlToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.commandsymlToolStripMenuItem.Text = "Commands.yml";
            this.commandsymlToolStripMenuItem.Click += new System.EventHandler(this.commandsymlToolStripMenuItem_Click);
            // 
            // commandToolStripMenuItem
            // 
            this.commandToolStripMenuItem.Name = "commandToolStripMenuItem";
            this.commandToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.commandToolStripMenuItem.Text = "Execute Command";
            this.commandToolStripMenuItem.Click += new System.EventHandler(this.commandToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandymlToolStripMenuItem,
            this.pluginymlToolStripMenuItem,
            this.bukkitymlToolStripMenuItem,
            this.permissionsymlToolStripMenuItem,
            this.helpymlToolStripMenuItem,
            this.toolStripMenuItem2,
            this.bukkitWikiToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // commandymlToolStripMenuItem
            // 
            this.commandymlToolStripMenuItem.Name = "commandymlToolStripMenuItem";
            this.commandymlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.commandymlToolStripMenuItem.Text = "Command.yml";
            this.commandymlToolStripMenuItem.Click += new System.EventHandler(this.commandymlToolStripMenuItem_Click);
            // 
            // pluginymlToolStripMenuItem
            // 
            this.pluginymlToolStripMenuItem.Name = "pluginymlToolStripMenuItem";
            this.pluginymlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pluginymlToolStripMenuItem.Text = "Plugin.yml";
            this.pluginymlToolStripMenuItem.Click += new System.EventHandler(this.pluginymlToolStripMenuItem_Click);
            // 
            // bukkitymlToolStripMenuItem
            // 
            this.bukkitymlToolStripMenuItem.Name = "bukkitymlToolStripMenuItem";
            this.bukkitymlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bukkitymlToolStripMenuItem.Text = "Bukkit.yml";
            this.bukkitymlToolStripMenuItem.Click += new System.EventHandler(this.bukkitymlToolStripMenuItem_Click);
            // 
            // permissionsymlToolStripMenuItem
            // 
            this.permissionsymlToolStripMenuItem.Name = "permissionsymlToolStripMenuItem";
            this.permissionsymlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.permissionsymlToolStripMenuItem.Text = "Permissions.yml";
            this.permissionsymlToolStripMenuItem.Click += new System.EventHandler(this.permissionsymlToolStripMenuItem_Click);
            // 
            // helpymlToolStripMenuItem
            // 
            this.helpymlToolStripMenuItem.Name = "helpymlToolStripMenuItem";
            this.helpymlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpymlToolStripMenuItem.Text = "Help.yml";
            this.helpymlToolStripMenuItem.Click += new System.EventHandler(this.helpymlToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = " ";
            // 
            // bukkitWikiToolStripMenuItem
            // 
            this.bukkitWikiToolStripMenuItem.Name = "bukkitWikiToolStripMenuItem";
            this.bukkitWikiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bukkitWikiToolStripMenuItem.Text = "Bukkit Wiki";
            this.bukkitWikiToolStripMenuItem.Click += new System.EventHandler(this.bukkitWikiToolStripMenuItem_Click);
            // 
            // ConfigEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ConfigEditor";
            this.Text = "Untitled - Config-Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringArrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrayObjectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandsymlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandsTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandymlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pluginymlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bukkitymlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permissionsymlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpymlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bukkitWikiToolStripMenuItem;
    }
}