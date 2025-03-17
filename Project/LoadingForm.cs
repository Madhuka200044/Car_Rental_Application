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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            StartLoading();
        }

         private void StartLoading()
        {
            Timer timer = new Timer();
            timer.Interval = 100; // Update every 100ms
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (LoadingBar.Value < 100)
            {
                LoadingBar.Value += 5; // Increment progress
            }
            else
            {
                ((Timer)sender).Stop();
                this.Hide();
                LoginForm loginForm = new LoginForm(); // Assuming LoginForm is your next form
                loginForm.Show();
            }
        }
    }
}
