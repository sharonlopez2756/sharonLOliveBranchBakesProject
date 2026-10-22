using System;
using System.Drawing;
using System.Windows.Forms;
using OliveBranchBakes.Models;

namespace OliveBranchBakes.Forms
{
    
    public partial class CustomerAccountForm : Form
    {
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
            MessageBox.Show("Login will be implemented in a later phase.", "Olive Branch Bakes",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registration will be implemented in a later phase.", "Olive Branch Bakes",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var welcome = new WelcomeForm();
            welcome.Show();
            this.Close();
        }
    }
}
