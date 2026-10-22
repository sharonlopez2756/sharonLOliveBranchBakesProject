using System;
using System.Drawing;
using System.Windows.Forms;
using OliveBranchBakes.Models;

namespace OliveBranchBakes.Forms
{
   
    // Administrator console prototype.
   
    public partial class AdminConsoleForm : Form
    {
        public AdminConsoleForm()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            this.BackColor = BakeryTheme.Cream;
            this.ForeColor = BakeryTheme.TextDark;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var welcome = new WelcomeForm();
            welcome.Show();
            this.Close();
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product management will be implemented in a later phase.",
                "Olive Branch Bakes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order management will be implemented in a later phase.",
                "Olive Branch Bakes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
