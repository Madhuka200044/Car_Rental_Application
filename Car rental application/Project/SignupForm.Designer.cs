﻿namespace Project
{
    partial class SignupForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LoginLinkBtn = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.SignupBtn = new System.Windows.Forms.Button();
            this.WELCOME = new System.Windows.Forms.Label();
            this.Epassword = new System.Windows.Forms.TextBox();
            this.EunserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reEpassword = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = global::Project.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 456);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(576, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "or";
            // 
            // LoginLinkBtn
            // 
            this.LoginLinkBtn.AutoSize = true;
            this.LoginLinkBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLinkBtn.Location = new System.Drawing.Point(602, 403);
            this.LoginLinkBtn.Name = "LoginLinkBtn";
            this.LoginLinkBtn.Size = new System.Drawing.Size(42, 16);
            this.LoginLinkBtn.TabIndex = 23;
            this.LoginLinkBtn.TabStop = true;
            this.LoginLinkBtn.Text = "Login";
            this.LoginLinkBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLinkBtn_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(488, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Hava an account ";
            // 
            // SignupBtn
            // 
            this.SignupBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SignupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupBtn.Location = new System.Drawing.Point(471, 325);
            this.SignupBtn.Margin = new System.Windows.Forms.Padding(10);
            this.SignupBtn.Name = "SignupBtn";
            this.SignupBtn.Size = new System.Drawing.Size(111, 38);
            this.SignupBtn.TabIndex = 21;
            this.SignupBtn.Text = "SIGN UP";
            this.SignupBtn.UseVisualStyleBackColor = false;
            this.SignupBtn.Click += new System.EventHandler(this.SignupBtn_Click);
            this.SignupBtn.Validating += new System.ComponentModel.CancelEventHandler(this.SignupBtn_Validating);
            // 
            // WELCOME
            // 
            this.WELCOME.AutoSize = true;
            this.WELCOME.BackColor = System.Drawing.Color.Transparent;
            this.WELCOME.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WELCOME.Location = new System.Drawing.Point(506, 27);
            this.WELCOME.Name = "WELCOME";
            this.WELCOME.Size = new System.Drawing.Size(138, 36);
            this.WELCOME.TabIndex = 20;
            this.WELCOME.Text = "Sign Up";
            this.WELCOME.Click += new System.EventHandler(this.WELCOME_Click);
            // 
            // Epassword
            // 
            this.Epassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Epassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Epassword.Location = new System.Drawing.Point(454, 215);
            this.Epassword.Margin = new System.Windows.Forms.Padding(10);
            this.Epassword.Name = "Epassword";
            this.Epassword.Size = new System.Drawing.Size(298, 20);
            this.Epassword.TabIndex = 19;
            this.Epassword.UseSystemPasswordChar = true;
            // 
            // EunserName
            // 
            this.EunserName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.EunserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EunserName.Location = new System.Drawing.Point(454, 140);
            this.EunserName.Margin = new System.Windows.Forms.Padding(10);
            this.EunserName.Name = "EunserName";
            this.EunserName.Size = new System.Drawing.Size(298, 20);
            this.EunserName.TabIndex = 18;
            this.EunserName.Validating += new System.ComponentModel.CancelEventHandler(this.EunserName_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Enter passowrd :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Enter user name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(106, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 36);
            this.label5.TabIndex = 25;
            this.label5.Text = "WELCOME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(411, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Re-enter passowrd :";
            // 
            // reEpassword
            // 
            this.reEpassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.reEpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reEpassword.Location = new System.Drawing.Point(454, 287);
            this.reEpassword.Margin = new System.Windows.Forms.Padding(10);
            this.reEpassword.Name = "reEpassword";
            this.reEpassword.Size = new System.Drawing.Size(298, 20);
            this.reEpassword.TabIndex = 27;
            this.reEpassword.UseSystemPasswordChar = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(602, 327);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(10);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(111, 38);
            this.ExitBtn.TabIndex = 28;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.reEpassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LoginLinkBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SignupBtn);
            this.Controls.Add(this.WELCOME);
            this.Controls.Add(this.Epassword);
            this.Controls.Add(this.EunserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SignupForm";
            this.Text = "SignupForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel LoginLinkBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SignupBtn;
        private System.Windows.Forms.Label WELCOME;
        private System.Windows.Forms.TextBox Epassword;
        private System.Windows.Forms.TextBox EunserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox reEpassword;
        private System.Windows.Forms.Button ExitBtn;
    }
}