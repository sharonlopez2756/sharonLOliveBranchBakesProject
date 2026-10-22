using System;
using System.Drawing;
using System.Windows.Forms;
using OliveBranchBakes.Models;

namespace OliveBranchBakes.Forms
{
   
    // Non-functional navigation buttons lead to the other prototype forms.
    
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            this.BackColor = BakeryTheme.Cream;
            this.ForeColor = BakeryTheme.TextDark;
            this.Font = new Font(BakeryTheme.PrimaryFontFamily, BakeryTheme.BodyFontSize);
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
