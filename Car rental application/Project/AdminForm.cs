using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void AddCarBtn_Click(object sender, EventArgs e)
        {
            AddCar addCar = new AddCar();
            addCar.Show();
            Close();


        }

        private void AddCusBtn_Click(object sender, EventArgs e)
        {
            CustomerForm Addcustomer = new CustomerForm();
            Addcustomer.Show();
            Close();
        }

        private void RenterBtn_Click(object sender, EventArgs e)
        {
            RentalForm rental = new RentalForm();
            rental.Show();
            Close();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            ReturnForm returnForm = new ReturnForm();
            returnForm.Show();
            Close();
        }
    }
}