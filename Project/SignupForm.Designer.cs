namespace Project
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
            this.label4 = new System.Windows.Forms.Label();
            this.LoginLinkBtn = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.SignupBtn = new System.Windows.Forms.Button();
            this.WELCOME = new System.Windows.Forms.Label();
            this.Epassword = new System.Windows.Forms.TextBox();
            this.EunserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reEpassword = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(768, 459);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "or";
            // 
            // LoginLinkBtn
            // 
            this.LoginLinkBtn.AutoSize = true;
            this.LoginLinkBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginLinkBtn.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLinkBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LoginLinkBtn.LinkColor = System.Drawing.Color.LightSkyBlue;
            this.LoginLinkBtn.Location = new System.Drawing.Point(786, 496);
            this.LoginLinkBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginLinkBtn.Name = "LoginLinkBtn";
            this.LoginLinkBtn.Size = new System.Drawing.Size(51, 19);
            this.LoginLinkBtn.TabIndex = 23;
            this.LoginLinkBtn.TabStop = true;
            this.LoginLinkBtn.Text = "Login";
            this.LoginLinkBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLinkBtn_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(642, 496);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Hava an account ";
            // 
            // SignupBtn
            // 
            this.SignupBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SignupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupBtn.Location = new System.Drawing.Point(628, 400);
            this.SignupBtn.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.SignupBtn.Name = "SignupBtn";
            this.SignupBtn.Size = new System.Drawing.Size(148, 47);
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
            this.WELCOME.ForeColor = System.Drawing.SystemColors.InfoText;
            this.WELCOME.Location = new System.Drawing.Point(677, 33);
            this.WELCOME.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WELCOME.Name = "WELCOME";
            this.WELCOME.Size = new System.Drawing.Size(175, 45);
            this.WELCOME.TabIndex = 20;
            this.WELCOME.Text = "Sign Up";
            this.WELCOME.Click += new System.EventHandler(this.WELCOME_Click);
            // 
            // Epassword
            // 
            this.Epassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Epassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Epassword.Location = new System.Drawing.Point(605, 265);
            this.Epassword.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.Epassword.Name = "Epassword";
            this.Epassword.Size = new System.Drawing.Size(397, 22);
            this.Epassword.TabIndex = 19;
            this.Epassword.UseSystemPasswordChar = true;
            // 
            // EunserName
            // 
            this.EunserName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.EunserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EunserName.Location = new System.Drawing.Point(605, 172);
            this.EunserName.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.EunserName.Name = "EunserName";
            this.EunserName.Size = new System.Drawing.Size(397, 22);
            this.EunserName.TabIndex = 18;
            this.EunserName.Validating += new System.ComponentModel.CancelEventHandler(this.EunserName_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(548, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Enter passowrd :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(548, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Enter user name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(548, 316);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Re-enter passowrd :";
            // 
            // reEpassword
            // 
            this.reEpassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.reEpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reEpassword.Location = new System.Drawing.Point(605, 353);
            this.reEpassword.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.reEpassword.Name = "reEpassword";
            this.reEpassword.Size = new System.Drawing.Size(397, 22);
            this.reEpassword.TabIndex = 27;
            this.reEpassword.UseSystemPasswordChar = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(803, 402);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(148, 47);
            this.ExitBtn.TabIndex = 28;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = global::Project.Properties.Resources.RoyalRent_car_rent__app_logo_car2;
            this.pictureBox1.Location = new System.Drawing.Point(37, 106);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 392);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(125, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 45);
            this.label5.TabIndex = 29;
            this.label5.Text = " WELCOME";
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = global::Project.Properties.Resources.Untitled_design__1_;
            this.ClientSize = new System.Drawing.Size(1033, 561);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.reEpassword);
            this.Controls.Add(this.label6);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignupForm";
            this.Text = "SignupForm";
            this.Load += new System.EventHandler(this.SignupForm_Load);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox reEpassword;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label5;
    }
}