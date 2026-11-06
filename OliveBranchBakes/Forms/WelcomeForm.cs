using System;
using System.Drawing;
using System.Windows.Forms;
using OliveBranchBakes.Models;

namespace OliveBranchBakes.Forms
{
   
   
    
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
       
        }


        private void btnOrder_Click(object sender, EventArgs e)
        {
            var orderForm = new CustomerOrderForm();
            orderForm.Show();
            this.Hide();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            var accountForm = new CustomerAccountForm();
            accountForm.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            var adminLogin = new AdminLoginForm();
            adminLogin.Show();
            this.Hide();
        }

        private void WelcomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
