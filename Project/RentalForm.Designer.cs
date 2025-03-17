namespace Project
{
    partial class RentalForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.returnday = new System.Windows.Forms.DateTimePicker();
            this.rentDay = new System.Windows.Forms.DateTimePicker();
            this.carIdtxt = new System.Windows.Forms.ComboBox();
            this.cusidtxt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RIDtxt = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(237, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(607, 39);
            this.label7.TabIndex = 24;
            this.label7.Text = "WELCOME TO RENTAL CAR OPTION.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.returnday);
            this.panel1.Controls.Add(this.rentDay);
            this.panel1.Controls.Add(this.carIdtxt);
            this.panel1.Controls.Add(this.cusidtxt);
            this.panel1.Controls.Add(this.RIDtxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 261);
            this.panel1.TabIndex = 25;
            // 
            // returnday
            // 
            this.returnday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnday.Location = new System.Drawing.Point(131, 217);
            this.returnday.Name = "returnday";
            this.returnday.Size = new System.Drawing.Size(236, 21);
            this.returnday.TabIndex = 75;
            this.returnday.Value = new System.DateTime(2025, 2, 23, 13, 3, 33, 0);
            // 
            // rentDay
            // 
            this.rentDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentDay.Location = new System.Drawing.Point(131, 171);
            this.rentDay.Name = "rentDay";
            this.rentDay.Size = new System.Drawing.Size(236, 21);
            this.rentDay.TabIndex = 26;
            this.rentDay.Value = new System.DateTime(2025, 2, 23, 13, 3, 33, 0);
            // 
            // carIdtxt
            // 
            this.carIdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.carIdtxt.ForeColor = System.Drawing.Color.OrangeRed;
            this.carIdtxt.FormattingEnabled = true;
            this.carIdtxt.Location = new System.Drawing.Point(176, 73);
            this.carIdtxt.Margin = new System.Windows.Forms.Padding(2);
            this.carIdtxt.Name = "carIdtxt";
            this.carIdtxt.Size = new System.Drawing.Size(191, 21);
            this.carIdtxt.TabIndex = 74;
            // 
            // cusidtxt
            // 
            this.cusidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.cusidtxt.ForeColor = System.Drawing.Color.OrangeRed;
            this.cusidtxt.FormattingEnabled = true;
            this.cusidtxt.Location = new System.Drawing.Point(176, 121);
            this.cusidtxt.Margin = new System.Windows.Forms.Padding(2);
            this.cusidtxt.Name = "cusidtxt";
            this.cusidtxt.Size = new System.Drawing.Size(191, 21);
            this.cusidtxt.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Return Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rental Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Rental Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer Id";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Car Id";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::Project.Properties.Resources.RoyalRent_car_rent__app_logo_car5;
            this.pictureBox1.Location = new System.Drawing.Point(21, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(380, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(556, 246);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "RentalID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CarID";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CustomerID";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "RentalDay";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ReturnDay";
            this.Column5.Name = "Column5";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(737, 461);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 35);
            this.button5.TabIndex = 33;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(453, 473);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 35);
            this.button3.TabIndex = 32;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(737, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 35);
            this.button2.TabIndex = 31;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(453, 416);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 35);
            this.button4.TabIndex = 30;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(608, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Car on rent";
            // 
            // RIDtxt
            // 
            this.RIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.RIDtxt.ForeColor = System.Drawing.Color.OrangeRed;
            this.RIDtxt.FormattingEnabled = true;
            this.RIDtxt.Location = new System.Drawing.Point(176, 25);
            this.RIDtxt.Margin = new System.Windows.Forms.Padding(2);
            this.RIDtxt.Name = "RIDtxt";
            this.RIDtxt.Size = new System.Drawing.Size(191, 21);
            this.RIDtxt.TabIndex = 72;
            this.RIDtxt.SelectedIndexChanged += new System.EventHandler(this.CarRegcb_SelectedIndexChanged);
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = global::Project.Properties.Resources.da04958d250a0a2e589d2d11286079241;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(948, 562);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RentalForm";
            this.Text = "RentalForm";
            this.Load += new System.EventHandler(this.RentalForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker returnday;
        private System.Windows.Forms.DateTimePicker rentDay;
        private System.Windows.Forms.ComboBox carIdtxt;
        private System.Windows.Forms.ComboBox cusidtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox RIDtxt;
    }
}