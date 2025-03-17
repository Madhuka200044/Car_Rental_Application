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

namespace Project
{
    public partial class ReturnForm : Form
    {
        public ReturnForm()
        {
            InitializeComponent();
            LoadData();
            LoadRentals();
            ReturnCar();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Car rental application\Project\CarReg.mdf"";Integrated Security=True");
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlDataReader dr;
        SqlDataReader dr2;
        String reID;

        private System.Windows.Forms.ComboBox cmbRentalID;
        private void LoadData()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM RentalTable", con))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dataGridView1.Rows.Clear();
                    while (dr.Read())
                    {
                        dataGridView1.Rows.Add(dr["RentID"], dr["CarID"], dr["CusID"], dr["RentDay"], dr["ReturnDay"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rental data: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }


        private void LoadRentals()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT RentID FROM RentalTable", con))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    RIDtxt.Items.Clear();

                    while (dr.Read())
                    {
                        if (!dr.IsDBNull(dr.GetOrdinal("RentID")))
                        {
                            RIDtxt.Items.Add(dr["RentID"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rental IDs: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }




        private void ReturnCar()
        {
            if (string.IsNullOrWhiteSpace(RIDtxt.Text))
            {
                MessageBox.Show("Please select a Rental ID.");
                return;
            }

            string rentalId = RIDtxt.Text;
            string carId = "";
            DateTime returnDate = DateTime.Now; // Current date for return
            DateTime dueDate;
            decimal extraCharge = 0;

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                // Get CarID and PayRentDay (due date) associated with the RentalID
                using (SqlCommand cmd = new SqlCommand("SELECT CarID, ReturnDay FROM RentalTable WHERE RentID = @RentID", con))
                {
                    cmd.Parameters.AddWithValue("@RentID", rentalId);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            carId = dr["CarID"].ToString();
                            dueDate = Convert.ToDateTime(dr["ReturnDay"]);
                        }
                        else
                        {
                            MessageBox.Show("Invalid Rental ID.");
                            return;
                        }
                    }
                }

                // Calculate extra charge if returned late
                if (returnDate > dueDate)
                {
                    int extraDays = (returnDate - dueDate).Days;
                    extraCharge = extraDays * 500; // Example charge of 500 per day
                }

                // Update car availability
                using (SqlCommand cmdUpdate = new SqlCommand("UPDATE AddCarTable SET Available = 'Yes' WHERE CarID = @CarID", con))
                {
                    cmdUpdate.Parameters.AddWithValue("@CarID", carId);
                    cmdUpdate.ExecuteNonQuery();
                }

                // Delete rental record
                using (SqlCommand cmdDelete = new SqlCommand("DELETE FROM RentalTable WHERE RentID = @RentID", con))
                {
                    cmdDelete.Parameters.AddWithValue("@RentID", rentalId);
                    cmdDelete.ExecuteNonQuery();
                }

                // Show alert if extra charge applies
                if (extraCharge > 0)
                {
                    MessageBox.Show($"Car returned successfully, but there is a late fee of Rs. {extraCharge}", "Late Return Fee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Car returned successfully.");
                }

                LoadData();
                LoadRentals();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }



        private void buttonReturn_Click(object sender, EventArgs e)
        {
            ReturnCar();
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReturnCar();
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {

        }
    }
}
