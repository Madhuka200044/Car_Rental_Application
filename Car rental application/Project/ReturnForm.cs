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
            LoadRentals();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Car rental application\Project\CarReg.mdf"";Integrated Security=True");
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlDataReader dr;
        SqlDataReader dr2;
        String reID;

        public void LoadData()
        {
            con.Open();
            string query = "select * from RentalTable";
            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4]);
            }
            con.Close();
        }

        public void LoadRentals()
        {
            con.Open();
            string query = "SELECT RentID FROM RentalTable"; // Shows only active rentals
            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();

            RIDtxt.Items.Clear(); // Clear previous data

            while (dr.Read())
            {
                RIDtxt.Items.Add(dr["RentID"].ToString()); // Add only rented cars
            }

            con.Close();
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
       
            // Ensure a Rental ID is entered
            if (string.IsNullOrWhiteSpace(RIDtxt.Text))
            {
                MessageBox.Show("Please enter or select a Rental ID to return the car.");
                return;
            }

            string rentID = RIDtxt.Text;
            string carID = "";

            try
            {
                con.Open();

                // Get CarID from RentalTable
                string getCarQuery = "SELECT CarID FROM RentalTable WHERE RentID = @RentID";
                cmd = new SqlCommand(getCarQuery, con);
                cmd.Parameters.AddWithValue("@RentID", rentID);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    carID = dr["CarID"].ToString();
                }
                dr.Close();

                // Check if CarID is found
                if (string.IsNullOrEmpty(carID))
                {
                    MessageBox.Show("Rental ID not found.");
                    con.Close();
                    return;
                }

                // Mark car as available again
                string updateCarQuery = "UPDATE AddCarTable SET Available = 'Yes' WHERE CarID = @CarID";
                cmd = new SqlCommand(updateCarQuery, con);
                cmd.Parameters.AddWithValue("@CarID", carID);
                cmd.ExecuteNonQuery();

                // Remove rental record (optional)
                string deleteRentalQuery = "DELETE FROM RentalTable WHERE RentID = @RentID";
                cmd = new SqlCommand(deleteRentalQuery, con);
                cmd.Parameters.AddWithValue("@RentID", rentID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Car returned successfully.");

                con.Close();

                // Refresh Data Grid
                LoadData();
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

        private void RIDtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rentID = RIDtxt.Text;
            string carID = "";
            decimal dailyRate = 0;
            int rentalDays = 0;
            DateTime rentDate, returnDate;

            try
            {
                con.Open();

                // Get Rental Details
                string rentalQuery = "SELECT CarID, CusID, RentDay, ReturnDay FROM RentalTable WHERE RentID = @RentID";
                using (SqlCommand cmd = new SqlCommand(rentalQuery, con))
                {
                    cmd.Parameters.AddWithValue("@RentID", rentID);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            carID = dr["CarID"].ToString();
                            cusidtxt.Text = dr["CusID"].ToString();
                            rentday.Text = dr["RentDay"].ToString();
                            dateTimePicker2.Text = dr["ReturnDay"].ToString(); // Fixed bug: Using returnday
                        }
                        else
                        {
                            MessageBox.Show("Rental ID not found.");
                            return;
                        }
                    }
                }

                // Get Car Rate
                string carQuery = "SELECT Payrentday FROM AddCarTable WHERE CarID = @CarID";
                using (SqlCommand cmd = new SqlCommand(carQuery, con))
                {
                    cmd.Parameters.AddWithValue("@CarID", carID);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            dailyRate = Convert.ToDecimal(dr["Payrentday"]);
                        }
                        else
                        {
                            MessageBox.Show("Car details not found.");
                            return;
                        }
                    }
                }

                // Calculate Rental Days
                if (!DateTime.TryParse(rentday.Text, out rentDate) || !DateTime.TryParse(dateTimePicker2.Text, out returnDate))
                {
                    MessageBox.Show("Invalid date format.");
                    return;
                }

                rentalDays = (returnDate - rentDate).Days;
                if (rentalDays < 0)
                {
                    MessageBox.Show("Invalid rental duration.");
                    return;
                }

                // Calculate Total Amount
                decimal totalAmount = rentalDays * dailyRate;
                lblTotalAmount.Text = $"Total: {totalAmount:C}"; // Formats as currency
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating payment: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

  

        private void ReturnForm_Load(object sender, EventArgs e)
        {

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

        private void carIdtxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalAmount_Click(object sender, EventArgs e)
        {

        }
    }
}

