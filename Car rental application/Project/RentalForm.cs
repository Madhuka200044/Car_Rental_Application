using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Project
{
    public partial class RentalForm : Form
    {
        public RentalForm()
        {
            InitializeComponent();
            carLoad();
            customerLoad();
            AutoNumber();
            LoadData();


        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Car rental application\Project\CarReg.mdf"";Integrated Security=True");
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlDataReader dr;
        SqlDataReader dr2;
        String reID;

        public void LoadData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Car rental application\Project\CarReg.mdf"";Integrated Security=True"))
                {
                    con.Open();
                    string query = "SELECT * FROM RentalTable";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        dataGridView1.Rows.Clear();
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4]);
                        }
                    }
                } // Connection closed automatically
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }


        public void AutoNumber()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Car rental application\Project\CarReg.mdf"";Integrated Security=True"))
                {
                    con.Open();

                    // Check for missing (deleted) IDs
                    string missingIDQuery = "SELECT MIN(a.RentID + 1) FROM RentalTable a WHERE NOT EXISTS (SELECT 1 FROM RentalTable b WHERE b.RentID = a.RentID + 1)";
                    using (SqlCommand cmd = new SqlCommand(missingIDQuery, con))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            reID = Convert.ToInt32(result).ToString("0000");
                        }
                        else
                        {
                            // If no missing ID, use max+1
                            string query = "SELECT ISNULL(MAX(RentID), 0) + 1 FROM RentalTable";
                            using (SqlCommand cmd2 = new SqlCommand(query, con))
                            {
                                reID = Convert.ToInt32(cmd2.ExecuteScalar()).ToString("0000");
                            }
                        }
                        RIDtxt.Text = reID;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating Rental ID: " + ex.Message);
            }
        }



        public void carLoad()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT CarID FROM AddCarTable WHERE Available = 'Yes'", con);
                dr = cmd.ExecuteReader();

                carIdtxt.Items.Clear();  // Prevent duplicates
                while (dr.Read())
                {
                    carIdtxt.Items.Add(dr["CarID"].ToString());
                }

                if (carIdtxt.Items.Count > 0)
                {
                    carIdtxt.SelectedIndex = 0; // Auto-select first item
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cars: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void customerLoad()
        {
            con.Open();
            cmd = new SqlCommand("select * from AddCustomerTable", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cusidtxt.Items.Add(dr["customerID"].ToString());
            }
            con.Close();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CarRegcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void button4_Click(object sender, EventArgs e)

        {
            string cid = carIdtxt.Text;
            string cusid = cusidtxt.Text;
            string rday = rentDay.Value.ToString("yyyy-MM-dd");
            string returnd = returnday.Value.ToString("yyyy-MM-dd");

            try
            {
                con.Open();


                string query = "INSERT INTO RentalTable (CarID, CusID, RentDay, ReturnDay) VALUES (@CarID, @CusID, @RentDay, @ReturnDay)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CarID", cid);
                cmd.Parameters.AddWithValue("@CusID", cusid);
                cmd.Parameters.AddWithValue("@RentDay", rday);
                cmd.Parameters.AddWithValue("@ReturnDay", returnd);
                cmd.ExecuteNonQuery();

                string query1 = "UPDATE AddCarTable SET Available = 'No' WHERE CarID = @CarID";
                cmd2 = new SqlCommand(query1, con);
                cmd2.Parameters.AddWithValue("@CarID", cid);
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Rental Added Successfully");

                carIdtxt.Items.Clear();
                cusidtxt.Items.Clear();

                con.Close();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
       
            if (string.IsNullOrWhiteSpace(RIDtxt.Text))
            {
                MessageBox.Show("Please enter or select a Rental ID to delete.");
                return;
            }

            string rentID = RIDtxt.Text;
            string carID = "";

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this rental?",
                                                   "Confirm Delete",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);
            if (confirm == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Car rental application\Project\CarReg.mdf"";Integrated Security=True"))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT CarID FROM RentalTable WHERE RentID = @RentID", con))
                    {
                        cmd.Parameters.AddWithValue("@RentID", rentID);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                carID = dr["CarID"].ToString();
                            }
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand("DELETE FROM RentalTable WHERE RentID = @RentID", con))
                    {
                        cmd.Parameters.AddWithValue("@RentID", rentID);
                        cmd.ExecuteNonQuery();
                    }

                    if (!string.IsNullOrEmpty(carID))
                    {
                        using (SqlCommand cmd2 = new SqlCommand("UPDATE AddCarTable SET Available = 'Yes' WHERE CarID = @CarID", con))
                        {
                            cmd2.Parameters.AddWithValue("@CarID", carID);
                            cmd2.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Rental record deleted successfully.");
                }
                LoadData();
                AutoNumber(); // ✅ Make sure a new ID is generated after delete
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void carIdtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar ==13)
            {
                con.Open();
                cmd = new SqlCommand("select * from AddCustomerTable where customerID = '" + cusidtxt.Text + "' ", con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cusidtxt.Text = dr["customerID"].ToString();
                }
                else
                {
                    MessageBox.Show("Customer ID not found");
                }
            }
        }

        private void carIdtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
      
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM AddCarTable WHERE CarID = @CarID", con);
                cmd.Parameters.AddWithValue("@CarID", carIdtxt.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string aval = dr["Available"].ToString().Trim();

                    label10.Text = aval;
                    if (aval.Equals("No", StringComparison.OrdinalIgnoreCase))
                    {
                        cusidtxt.Enabled = false;
                        rentDay.Enabled = false;
                        returnday.Enabled = false;
                    }
                    else
                    {
                        cusidtxt.Enabled = true;
                        rentDay.Enabled = true;
                        returnday.Enabled = true;
                    }
                }
                else
                {
                    label10.Text = "Not Available";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void RentalForm_Load(object sender, EventArgs e)
        {

        }
    }
}

