namespace SpigotGUI
{
    partial class PlayerControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerControl));
            this.labelUser = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonPIP = new System.Windows.Forms.Button();
            this.buttonBIP = new System.Windows.Forms.Button();
            this.buttonPardon = new System.Windows.Forms.Button();
            this.textBoxReason = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBan = new System.Windows.Forms.Button();
            this.buttonKick = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(13, 13);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(96, 13);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "Username: BLANK";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(49)))));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(143, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 68);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Staff Management";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Remove Operator";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Give Operator";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(49)))));
            this.groupBox2.Controls.Add(this.buttonPIP);
            this.groupBox2.Controls.Add(this.buttonBIP);
            this.groupBox2.Controls.Add(this.buttonPardon);
            this.groupBox2.Controls.Add(this.textBoxReason);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonBan);
            this.groupBox2.Controls.Add(this.buttonKick);
            this.groupBox2.Location = new System.Drawing.Point(143, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 169);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Punishments";
            // 
            // buttonPIP
            // 
            this.buttonPIP.Location = new System.Drawing.Point(147, 78);
            this.buttonPIP.Name = "buttonPIP";
            this.buttonPIP.Size = new System.Drawing.Size(75, 23);
            this.buttonPIP.TabIndex = 7;
            this.buttonPIP.Text = "Pardon IP";
            this.buttonPIP.UseVisualStyleBackColor = true;
            this.buttonPIP.Click += new System.EventHandler(this.buttonPIP_Click);
            // 
            // buttonBIP
            // 
            this.buttonBIP.Location = new System.Drawing.Point(7, 78);
            this.buttonBIP.Name = "buttonBIP";
            this.buttonBIP.Size = new System.Drawing.Size(75, 23);
            this.buttonBIP.TabIndex = 6;
            this.buttonBIP.Text = "Ban IP";
            this.buttonBIP.UseVisualStyleBackColor = true;
            this.buttonBIP.Click += new System.EventHandler(this.buttonBIP_Click);
            // 
            // buttonPardon
            // 
            this.buttonPardon.Location = new System.Drawing.Point(147, 49);
            this.buttonPardon.Name = "buttonPardon";
            this.buttonPardon.Size = new System.Drawing.Size(75, 23);
            this.buttonPardon.TabIndex = 5;
            this.buttonPardon.Text = "Pardon Player";
            this.buttonPardon.UseVisualStyleBackColor = true;
            this.buttonPardon.Click += new System.EventHandler(this.buttonPardon_Click);
            // 
            // textBoxReason
            // 
            this.textBoxReason.Location = new System.Drawing.Point(6, 143);
            this.textBoxReason.Name = "textBoxReason";
            this.textBoxReason.Size = new System.Drawing.Size(216, 20);
            this.textBoxReason.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reason";
            // 
            // buttonBan
            // 
            this.buttonBan.Location = new System.Drawing.Point(7, 49);
            this.buttonBan.Name = "buttonBan";
            this.buttonBan.Size = new System.Drawing.Size(75, 23);
            this.buttonBan.TabIndex = 1;
            this.buttonBan.Text = "Ban Player";
            this.buttonBan.UseVisualStyleBackColor = true;
            this.buttonBan.Click += new System.EventHandler(this.buttonBan_Click);
            // 
            // buttonKick
            // 
            this.buttonKick.Location = new System.Drawing.Point(7, 20);
            this.buttonKick.Name = "buttonKick";
            this.buttonKick.Size = new System.Drawing.Size(75, 23);
            this.buttonKick.TabIndex = 0;
            this.buttonKick.Text = "Kick Player";
            this.buttonKick.UseVisualStyleBackColor = true;
            this.buttonKick.Click += new System.EventHandler(this.buttonKick_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(49)))));
            this.groupBox3.Location = new System.Drawing.Point(150, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misc";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(13, 30);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(69, 13);
            this.labelIP.TabIndex = 4;
            this.labelIP.Text = "IP: Unknown";
            // 
            // PlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(383, 383);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PlayerControl";
            this.Text = "PlayerControl";
            this.Load += new System.EventHandler(this.PlayerControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonBan;
        private System.Windows.Forms.Button buttonKick;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxReason;
        private System.Windows.Forms.Button buttonPardon;
        private System.Windows.Forms.Button buttonPIP;
        private System.Windows.Forms.Button buttonBIP;
        private System.Windows.Forms.Label labelIP;
    }
}