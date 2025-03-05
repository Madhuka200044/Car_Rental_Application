using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    

namespace Project
{
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
            AutoNumber();
            LoadData();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Car rental application\Project\CarReg.mdf"";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        String CarID;
        bool mode = true;



        public void AutoNumber()
        {
            
            string query = "select count(CarID) from AddCarTable";
            cmd = new SqlCommand(query, con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                CarID = "A" + id.ToString("0000");
            }
            else if (Convert.IsDBNull(dr))
            {
                CarID = "A0000";
            }
            else
            {
                CarID = "A0000";
            }

            txtcid.Text = CarID.ToString();
            con.Close();
        }

        public void LoadData()
        {
            con.Open();
            string query = "select * from AddCarTable";
            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4]);
            }
            con.Close();
        }





        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddCar_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cid = txtcid.Text;
            string cnum = txtcarno.Text;
            string cmodel = txtbrand.Text;
            string rpd = txtrpd.Text;
            string avalable = AvalbleOrNot.SelectedItem.ToString();

            try
            {

                if (mode == true)
                {
                    string query = "insert into AddCarTable(CarID,CarNum,CarModel,Payrentday,Available) values('" + cid + "','" + cnum + "','" + cmodel + "','" + rpd + "','" + avalable + "')";
                    con.Open();
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("CarID", txtcid.Text);
                    cmd.Parameters.AddWithValue("CarNum", txtcarno.Text);
                    cmd.Parameters.AddWithValue("CarModel", txtbrand.Text);
                    cmd.Parameters.AddWithValue("Payrentday", txtrpd.Text);
                    cmd.Parameters.AddWithValue("Available", AvalbleOrNot.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Car Added Successfully");
                    txtcid.Clear();
                    txtcarno.Clear();
                    txtbrand.Clear();
                    txtrpd.Clear();
                    AvalbleOrNot.SelectedIndex = -1;
                    LoadData();
                }
                else
                {
                    string query = "update AddCarTable set CarNum = '" + cnum + "',CarModel = '" + cmodel + "',Payrentday = '" + rpd + "',Available = '" + avalable + "' where CarID = '" + cid + "'";
                    con.Open();
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Car Updated Successfully");
                    txtcid.Clear();
                    txtcarno.Clear();
                    txtbrand.Clear();
                    txtrpd.Clear();
                    AvalbleOrNot.SelectedIndex = -1;
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ensure a car is selected
            if (string.IsNullOrWhiteSpace(txtcid.Text))
            {
                MessageBox.Show("Please enter a valid Car ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string cid = txtcid.Text;
            string cnum = txtcarno.Text;
            string cmodel = txtbrand.Text;
            string rpd = txtrpd.Text;
            string available = AvalbleOrNot.SelectedItem?.ToString(); // Handle potential null

            if (available == null)
            {
                MessageBox.Show("Please select availability status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = "UPDATE AddCarTable SET CarNum = @CarNum, CarModel = @CarModel, Payrentday = @Payrentday, Available = @Available WHERE CarID = @CarID";

                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Car rental application\Project\CarReg.mdf"";Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CarID", cid);
                        cmd.Parameters.AddWithValue("@CarNum", cnum);
                        cmd.Parameters.AddWithValue("@CarModel", cmodel);
                        cmd.Parameters.AddWithValue("@Payrentday", rpd);
                        cmd.Parameters.AddWithValue("@Available", available);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        con.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Car details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("No matching Car ID found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating car details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtcid.Clear();
            txtcarno.Clear();
            txtbrand.Clear();
            txtrpd.Clear();
            AvalbleOrNot.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ensure a car is selected
            if (string.IsNullOrWhiteSpace(txtcid.Text))
            {
                MessageBox.Show("Please select a car to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this car?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM AddCarTable WHERE CarID = @CarID";

                    using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Car rental application\Project\CarReg.mdf"";Integrated Security=True"))
                    {
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@CarID", txtcid.Text);

                            con.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            con.Close();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Car deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData(); // Refresh DataGridView
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("No matching Car ID found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting car: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminForm AForm = new AdminForm();

            DialogResult result = MessageBox.Show("Are you sure you want to Back?", "Confirm Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                AForm.Show();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
