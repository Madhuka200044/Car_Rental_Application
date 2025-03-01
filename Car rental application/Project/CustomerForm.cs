using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Project
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            LoadData();
            AutoNumber();
        }

        SqlConnection cus = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Car rental application\Project\CarReg.mdf"";Integrated Security=True");
        SqlCommand cmd2;
        SqlDataReader dr2;
        String customerID;
        bool mode2 = true;


        public void LoadData()
        {
            cus.Open();
            string query = "select * from AddCustomerTable";
            cmd2 = new SqlCommand(query, cus);
            dr2 = cmd2.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr2.Read())
            {
                dataGridView1.Rows.Add(dr2[0], dr2[1], dr2[2], dr2[3]);
            }
            cus.Close();
        }

        public void AutoNumber()
        {

            string query = "select count(customerID) from AddCustomerTable";
            cmd2 = new SqlCommand(query, cus);
            cus.Open();
            dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                int id = int.Parse(dr2[0].ToString()) + 1;
                customerID = "C" + id.ToString("0000");
            }
            else if (Convert.IsDBNull(dr2))
            {
                customerID = "C0000";
            }
            else
            {
                customerID = "C0000";
            }

            txtCusID.Text = customerID.ToString();
            cus.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cusId = txtCusID.Text;
            string cusName = txtcusName.Text;
            string cusIDNumber = txtcusIDn.Text;
            string cusPhone = txtcusPhone.Text;


            if (mode2 == true)
            {
                string query = "insert into AddCustomerTable(customerID,customerName,customerIDNumber,customerPhoneNumber) values('" + cusId + "','" + cusName + "','" + cusIDNumber + "','" + cusPhone + "')";
                cus.Open();
                cmd2 = new SqlCommand(query, cus);
                cmd2.Parameters.AddWithValue("customerID", txtCusID.Text);
                cmd2.Parameters.AddWithValue("customerName", txtcusName.Text);
                cmd2.Parameters.AddWithValue("customerIDnumber", txtcusIDn.Text);
                cmd2.Parameters.AddWithValue("customerPhoneNumber", txtcusPhone.Text);

                cmd2.ExecuteNonQuery();
                cus.Close();
                MessageBox.Show("Customer Added Successfully");
                txtCusID.Clear();
                txtcusName.Clear();
                txtcusIDn.Clear();
                txtcusPhone.Clear();
                LoadData();
            }
            else
            {
                string query = "update AddCarTable set customerName = '" + cusName + "',customerIDNumber = '" + cusIDNumber + "',customerPhoneNumber = '" + cusPhone + "' where customerID = '" + cusId + "'";
                cus.Open();
                cmd2 = new SqlCommand(query, cus);
                cmd2.ExecuteNonQuery();
                cus.Close();
                MessageBox.Show("Customer Updated Successfully");
                txtCusID.Clear();
                txtcusName.Clear();
                txtcusIDn.Clear();
                txtcusPhone.Clear();
                LoadData();
            }

        }

        private void txtcusClear_Click(object sender, EventArgs e)
        {
            txtCusID.Clear();
            txtcusName.Clear();
            txtcusIDn.Clear();
            txtcusPhone.Clear();
        }

        private void txtcusDelete_Click(object sender, EventArgs e)
        {
            // Ensure a car is selected
            if (string.IsNullOrWhiteSpace(txtCusID.Text))
            {
                MessageBox.Show("Please select a customer to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this customer ?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM AddCustomerTable WHERE customerID = @cusID";

                    using (SqlConnection cus = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Car rental application\Project\CarReg.mdf"";Integrated Security=True"))
                    {
                        using (SqlCommand cmd2 = new SqlCommand(query, cus))
                        {
                            cmd2.Parameters.AddWithValue("@cusID", txtCusID.Text);

                            cus.Open();
                            int rowsAffected = cmd2.ExecuteNonQuery();
                            cus.Close();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData(); // Refresh DataGridView
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("No matching Customer ID found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtcusBack_Click(object sender, EventArgs e)
        {
            AdminForm AForm = new AdminForm();

            DialogResult result = MessageBox.Show("Are you sure you want to Back?", "Confirm Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                AForm.Show();
            }
        }

        private void txtcusexit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtcusUpdate_Click(object sender, EventArgs e)
        {

            string query = "UPDATE AddCustomerTable SET customerName = @customerName, customerIDNumber = @customerIDNumber, customerPhoneNumber = @customerPhone WHERE customerID = @customerID";

           
            {
                SqlCommand cmd2 = new SqlCommand(query, cus);

                // Adding parameters properly
                cmd2.Parameters.AddWithValue("@customerName", txtcusName.Text);
                cmd2.Parameters.AddWithValue("@customerIDNumber", txtcusIDn.Text);
                cmd2.Parameters.AddWithValue("@customerPhone", txtcusPhone.Text);
                cmd2.Parameters.AddWithValue("@customerID", txtCusID.Text);  // Ensure this is set correctly

                cus.Open();
                int rowsAffected = cmd2.ExecuteNonQuery();
                cus.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCusID.Clear();
                    txtcusName.Clear();
                    txtcusIDn.Clear();
                    txtcusPhone.Clear();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("No matching Customer ID found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

    }
    
}
