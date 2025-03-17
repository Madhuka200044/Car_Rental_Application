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
    public partial class RentalForm : Form
    {
        public RentalForm()
        {
            InitializeComponent();
            carLoad();
            customerLoad();
           // AutoNumber();
            LoadData();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Car rental application\Project\CarReg.mdf"";Integrated Security=True");
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlDataReader dr;
        SqlDataReader dr2;
        String reID;
        String RentID;

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

                    string query = "select count(RentID) from RentalTable";
                    cmd = new SqlCommand(query, con);

                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        int id = int.Parse(dr[0].ToString()) + 1;
                        RentID = "R" + id.ToString("0000");
                    }
                    else if (Convert.IsDBNull(dr))
                    {
                        RentID = "R0000";
                    }
                    else
                    {
                        RentID = "R0000";
                    }

                    RIDtxt.Text = RentID.ToString();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating RentID: " + ex.Message);
            }
        }




        public void carLoad()
        {
            try
            {
                con.Open();  
                cmd = new SqlCommand("SELECT CarID FROM AddCarTable WHERE Available = 'Yes'", con);
                dr = cmd.ExecuteReader();

                carIdtxt.Items.Clear(); 
                while (dr.Read())
                {
                    carIdtxt.Items.Add(dr["CarID"].ToString());
                }

                if (carIdtxt.Items.Count > 0)
                {
                    carIdtxt.SelectedIndex = 0; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cars: " + ex.Message);
            }
            finally
            {
                dr?.Close();  
                if (con.State == ConnectionState.Open) con.Close();
            }
        }



        public void customerLoad()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT customerID FROM AddCustomerTable", con);
                dr = cmd.ExecuteReader();

                cusidtxt.Items.Clear(); 
                while (dr.Read())
                {
                    cusidtxt.Items.Add(dr["customerID"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message);
            }
            finally
            {
                dr?.Close(); 
                if (con.State == ConnectionState.Open) con.Close(); 
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CarRegcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
      
            string RentID = RIDtxt.Text;  // Using the generated RentID
            string CarID = carIdtxt.SelectedItem.ToString();
            string CusID = cusidtxt.SelectedItem.ToString();
            string RentDay = rentDay.Value.ToString("yyyy-MM-dd");
            string ReturnDay = returnday.Value.ToString("yyyy-MM-dd");

            try
            {
                con.Open();

                // Generate the query to insert the data
                string query = "INSERT INTO RentalTable (CarID, CusID, RentDay, ReturnDay) VALUES ( @CarID, @CusID, @RentDay, @ReturnDay)";
                cmd = new SqlCommand(query, con);

              // cmd.Parameters.AddWithValue("@RentID", RentID);
                cmd.Parameters.AddWithValue("@CarID", CarID);
                cmd.Parameters.AddWithValue("@CusID", CusID);
                cmd.Parameters.AddWithValue("@RentDay", RentDay);
                cmd.Parameters.AddWithValue("@ReturnDay", ReturnDay);

                cmd.ExecuteNonQuery();

                // Update car availability after rental
                string updateQuery = "UPDATE AddCarTable SET Available = 'No' WHERE CarID = @CarID";
                cmd2 = new SqlCommand(updateQuery, con);
                cmd2.Parameters.AddWithValue("@CarID", CarID);
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Rental Added Successfully");

                // Clear inputs and reload data
                carIdtxt.Items.Clear();
                cusidtxt.Items.Clear();

                con.Close();
                LoadData();  // Reload the data to show the new entry
                carLoad();
                customerLoad();
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

            string RentID = RIDtxt.Text;
            string CarID = "";

            try
            {
                con.Open();

                
                string selectQuery = "SELECT CarID FROM RentalTable WHERE RentID = @RentID";
                cmd = new SqlCommand(selectQuery, con);
                cmd.Parameters.AddWithValue("@RentID", RentID);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        CarID = reader["CarID"].ToString();
                    }
                }

                if (string.IsNullOrEmpty(CarID))
                {
                    MessageBox.Show("Rental record not found.");
                    return;
                }

              
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    string deleteQuery = "DELETE FROM RentalTable WHERE RentID = @RentID";
                    cmd = new SqlCommand(deleteQuery, con, transaction);
                    cmd.Parameters.AddWithValue("@RentID", RentID);
                    cmd.ExecuteNonQuery();

                    
                    string updateQuery = "UPDATE AddCarTable SET Available = 'Yes' WHERE CarID = @CarID";
                    cmd = new SqlCommand(updateQuery, con, transaction);
                    cmd.Parameters.AddWithValue("@CarID", CarID);
                    cmd.ExecuteNonQuery();

                  
                    transaction.Commit();
                    MessageBox.Show("Rental record deleted successfully.");
                }
                catch (Exception ex)
                {
                
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
                LoadData();
                AutoNumber(); 
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

        private void RentalForm_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
