using System;
using System.Drawing;
using System.Windows.Forms;
using OliveBranchBakes.Models;

namespace OliveBranchBakes.Forms
{
    
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
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
            // Prototype: open console without real authentication
            var console = new AdminConsoleForm();
            console.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var welcome = new WelcomeForm();
            welcome.Show();
            this.Close();
        }
    }
}
