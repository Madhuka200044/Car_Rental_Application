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
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }
        SqlConnection signup = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Car rental application\Project\CarReg.mdf"";Integrated Security=True");
        SqlCommand cmd3;
        SqlDataReader sup;

        bool mode3 = true;

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
            String User = EUname.Text;
            String Password = Epassword.Text;
            String RePassword = reEpassword.Text;

            if (mode3 == true)
            {
                if (User == "" || Password == "" || RePassword == "")
                {
                    MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Password != RePassword)
                {
                    MessageBox.Show("Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    signup.Open();
                    cmd3 = new SqlCommand("select * from Signup where Username = '" + EUname.Text + "'", signup);
                    sup = cmd3.ExecuteReader();
                    if (sup.Read())
                    {
                        MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        signup.Close();
                    }
                    else
                    {
                        signup.Close();
                        signup.Open();
                        cmd3 = new SqlCommand("insert into Signup(Username, Password) values('" + EUname.Text + "','" + Epassword.Text + "')", signup);
                        cmd3.ExecuteNonQuery();
                        signup.Close();
                        MessageBox.Show("Account created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoginForm LForm = new LoginForm();
                        this.Hide();
                        LForm.Show();
                    }
                }
            }
        }
    }
}
