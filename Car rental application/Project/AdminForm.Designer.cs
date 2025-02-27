namespace Project
{
    partial class AdminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddCusBtn = new System.Windows.Forms.Button();
            this.AddCarBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RenterBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME TO SUPER CAR RENTAL";
            // 
            // AddCusBtn
            // 
            this.AddCusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCusBtn.Location = new System.Drawing.Point(294, 162);
            this.AddCusBtn.Name = "AddCusBtn";
            this.AddCusBtn.Size = new System.Drawing.Size(220, 41);
            this.AddCusBtn.TabIndex = 3;
            this.AddCusBtn.Text = "ADD CUSTOMER";
            this.AddCusBtn.UseVisualStyleBackColor = true;
            // 
            // AddCarBtn
            // 
            this.AddCarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarBtn.Location = new System.Drawing.Point(294, 105);
            this.AddCarBtn.Name = "AddCarBtn";
            this.AddCarBtn.Size = new System.Drawing.Size(220, 41);
            this.AddCarBtn.TabIndex = 4;
            this.AddCarBtn.Text = "ADD CAR";
            this.AddCarBtn.UseVisualStyleBackColor = true;
            this.AddCarBtn.Click += new System.EventHandler(this.AddCarBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Location = new System.Drawing.Point(150, 357);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(139, 35);
            this.LogoutBtn.TabIndex = 5;
            this.LogoutBtn.Text = "Log Out";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(482, 357);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(139, 35);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(-13, -29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RenterBtn
            // 
            this.RenterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenterBtn.Location = new System.Drawing.Point(294, 218);
            this.RenterBtn.Name = "RenterBtn";
            this.RenterBtn.Size = new System.Drawing.Size(220, 41);
            this.RenterBtn.TabIndex = 7;
            this.RenterBtn.Text = "RENTER CAR";
            this.RenterBtn.UseVisualStyleBackColor = true;
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBtn.Location = new System.Drawing.Point(294, 278);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(220, 41);
            this.ReturnBtn.TabIndex = 8;
            this.ReturnBtn.Text = "RETURN CAR";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.RenterBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.AddCarBtn);
            this.Controls.Add(this.AddCusBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddCusBtn;
        private System.Windows.Forms.Button AddCarBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button RenterBtn;
        private System.Windows.Forms.Button ReturnBtn;
    }
}