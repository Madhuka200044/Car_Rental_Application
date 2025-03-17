using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }
        SqlConnection Login = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Car rental application\Project\CarReg.mdf"";Integrated Security=True");
        SqlCommand cmd4;
        SqlDataReader dr4;
        bool mode5 = true;

        private void WELCOME_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LoginLinkBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm LForm = new LoginForm();
            this.Hide();
            LForm.Show();
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            string UserName = EunserName.Text.Trim();
            string password = Epassword.Text.Trim();
            string REpassword = reEpassword.Text.Trim();

            // Regex patterns
            string usernamePattern = @"^[a-zA-Z0-9_]{3,20}$"; // Allows 3-20 characters (letters, numbers, underscore)
            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&]).{6,}$"; // Allows 6+ chars, with one uppercase, one lowercase, one number, one special char

            // Validate inputs
            if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(REpassword))
            {
                MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate username
            if (!Regex.IsMatch(UserName, usernamePattern))
            {
                MessageBox.Show("Invalid Username! Use 3-20 characters (letters, numbers, underscore).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate password (6 characters min, uppercase, lowercase, number, special char)
            if (!Regex.IsMatch(password, passwordPattern))
            {
                MessageBox.Show("Weak password! Must be at least 6 characters, include uppercase, lowercase, number, and special character.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if passwords match
            if (password != REpassword)
            {
                MessageBox.Show("Passwords do not match!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (mode5)
                {
                    string query = "INSERT INTO AdminLoginData (UserName, Password, rePassword) VALUES (@UserName, @Password, @rePassword)";

                    Login.Open();
                    using (SqlCommand cmd4 = new SqlCommand(query, Login))
                    {
                        cmd4.Parameters.AddWithValue("@UserName", UserName);
                        cmd4.Parameters.AddWithValue("@Password", password); // Consider hashing this!
                        cmd4.Parameters.AddWithValue("@rePassword", REpassword);

                        int result = cmd4.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Account Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear input fields
                            EunserName.Clear();
                            Epassword.Clear();
                            reEpassword.Clear();

                            // Navigate to Login Form
                            LoginForm LForm = new LoginForm();
                            this.Hide();
                            LForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Signup failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Login.State == System.Data.ConnectionState.Open)
                {
                    Login.Close();
                }
            }
        }


        private void SignupBtn_Validating(object sender, CancelEventArgs e)
        {

        }

        private void EunserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EunserName.Text))
            {
                e.Cancel = true; // Prevents leaving the field
                MessageBox.Show("Username cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
