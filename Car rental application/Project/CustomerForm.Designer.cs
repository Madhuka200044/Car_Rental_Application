namespace Project
{
    partial class CustomerForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcusPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcusIDn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcusName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcusexit = new System.Windows.Forms.Button();
            this.txtcusBack = new System.Windows.Forms.Button();
            this.txtcusClear = new System.Windows.Forms.Button();
            this.txtcusUpdate = new System.Windows.Forms.Button();
            this.AddCuBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcusDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(-11, -32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(150, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(651, 39);
            this.label7.TabIndex = 22;
            this.label7.Text = "WELCOME TO ADD CUSTOMER OPTION.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtCusID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtcusPhone);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtcusIDn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtcusName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 218);
            this.panel1.TabIndex = 23;
            // 
            // txtCusID
            // 
            this.txtCusID.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusID.Location = new System.Drawing.Point(176, 16);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(165, 33);
            this.txtCusID.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightCyan;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Customer Id";
            // 
            // txtcusPhone
            // 
            this.txtcusPhone.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcusPhone.Location = new System.Drawing.Point(176, 160);
            this.txtcusPhone.Name = "txtcusPhone";
            this.txtcusPhone.Size = new System.Drawing.Size(165, 33);
            this.txtcusPhone.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightCyan;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Contact Number";
            // 
            // txtcusIDn
            // 
            this.txtcusIDn.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcusIDn.Location = new System.Drawing.Point(176, 112);
            this.txtcusIDn.Name = "txtcusIDn";
            this.txtcusIDn.Size = new System.Drawing.Size(165, 33);
            this.txtcusIDn.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightCyan;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id No";
            // 
            // txtcusName
            // 
            this.txtcusName.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcusName.Location = new System.Drawing.Point(176, 64);
            this.txtcusName.Name = "txtcusName";
            this.txtcusName.Size = new System.Drawing.Size(165, 33);
            this.txtcusName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(351, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 246);
            this.dataGridView1.TabIndex = 24;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nic ID";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Contact Number";
            this.Column4.Name = "Column4";
            // 
            // txtcusexit
            // 
            this.txtcusexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcusexit.Location = new System.Drawing.Point(641, 403);
            this.txtcusexit.Name = "txtcusexit";
            this.txtcusexit.Size = new System.Drawing.Size(139, 35);
            this.txtcusexit.TabIndex = 29;
            this.txtcusexit.Text = "Exit";
            this.txtcusexit.UseVisualStyleBackColor = true;
            this.txtcusexit.Click += new System.EventHandler(this.txtcusexit_Click);
            // 
            // txtcusBack
            // 
            this.txtcusBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcusBack.Location = new System.Drawing.Point(496, 403);
            this.txtcusBack.Name = "txtcusBack";
            this.txtcusBack.Size = new System.Drawing.Size(139, 35);
            this.txtcusBack.TabIndex = 28;
            this.txtcusBack.Text = "Back";
            this.txtcusBack.UseVisualStyleBackColor = true;
            this.txtcusBack.Click += new System.EventHandler(this.txtcusBack_Click);
            // 
            // txtcusClear
            // 
            this.txtcusClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcusClear.Location = new System.Drawing.Point(641, 362);
            this.txtcusClear.Name = "txtcusClear";
            this.txtcusClear.Size = new System.Drawing.Size(139, 35);
            this.txtcusClear.TabIndex = 27;
            this.txtcusClear.Text = "Clear ";
            this.txtcusClear.UseVisualStyleBackColor = true;
            this.txtcusClear.Click += new System.EventHandler(this.txtcusClear_Click);
            // 
            // txtcusUpdate
            // 
            this.txtcusUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcusUpdate.Location = new System.Drawing.Point(496, 362);
            this.txtcusUpdate.Name = "txtcusUpdate";
            this.txtcusUpdate.Size = new System.Drawing.Size(139, 35);
            this.txtcusUpdate.TabIndex = 26;
            this.txtcusUpdate.Text = "Update";
            this.txtcusUpdate.UseVisualStyleBackColor = true;
            this.txtcusUpdate.Click += new System.EventHandler(this.txtcusUpdate_Click);
            // 
            // AddCuBtn
            // 
            this.AddCuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCuBtn.Location = new System.Drawing.Point(351, 362);
            this.AddCuBtn.Name = "AddCuBtn";
            this.AddCuBtn.Size = new System.Drawing.Size(139, 35);
            this.AddCuBtn.TabIndex = 25;
            this.AddCuBtn.Text = "Add Customer";
            this.AddCuBtn.UseVisualStyleBackColor = true;
            this.AddCuBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(518, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Customer list";
            // 
            // txtcusDelete
            // 
            this.txtcusDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcusDelete.Location = new System.Drawing.Point(351, 403);
            this.txtcusDelete.Name = "txtcusDelete";
            this.txtcusDelete.Size = new System.Drawing.Size(139, 35);
            this.txtcusDelete.TabIndex = 30;
            this.txtcusDelete.Text = "Delete";
            this.txtcusDelete.UseVisualStyleBackColor = true;
            this.txtcusDelete.Click += new System.EventHandler(this.txtcusDelete_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcusDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcusexit);
            this.Controls.Add(this.txtcusBack);
            this.Controls.Add(this.txtcusClear);
            this.Controls.Add(this.txtcusUpdate);
            this.Controls.Add(this.AddCuBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtcusPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcusIDn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcusName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button txtcusexit;
        private System.Windows.Forms.Button txtcusBack;
        private System.Windows.Forms.Button txtcusClear;
        private System.Windows.Forms.Button txtcusUpdate;
        private System.Windows.Forms.Button AddCuBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button txtcusDelete;
    }
}