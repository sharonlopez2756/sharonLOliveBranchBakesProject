using System;
using System.Drawing;
using System.Windows.Forms;
using OliveBranchBakes.Models;
using OliveBranchBakes.Services;

namespace OliveBranchBakes.Forms
{
    public partial class CustomerAccountForm : Form
    {
        private readonly ICustomerService _accounts = new CustomerService();

        public CustomerAccountForm()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            this.BackColor = BakeryTheme.Cream;
            this.ForeColor = BakeryTheme.TextDark;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Customer c = _accounts.Login(txtEmail.Text, txtPassword.Text);
                Session.CurrentCustomer = c;
                MessageBox.Show("Signed in as " + c.FullName, "Olive Branch Bakes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sign in failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string first = "Guest";
                string last = "Customer";
                string email = txtEmail.Text;
                if (!string.IsNullOrWhiteSpace(email) && email.Contains("@"))
                {
                    first = email.Split('@')[0];
                }

                Customer c = _accounts.Register(first, last, email, "", txtPassword.Text);
                Session.CurrentCustomer = c;
                MessageBox.Show("Account created for " + c.Email, "Olive Branch Bakes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Registration failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var welcome = new WelcomeForm();
            welcome.Show();
            this.Close();
        }
    }
}
