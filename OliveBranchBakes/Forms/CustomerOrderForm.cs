using System;
using System.Drawing;
using System.Windows.Forms;
using OliveBranchBakes.Models;

namespace OliveBranchBakes.Forms
{
   
    public partial class CustomerOrderForm : Form
    {
        public CustomerOrderForm()
        {
            InitializeComponent();
            ApplyTheme();
            LoadSampleProducts(); // Visual sample data only
        }

        private void ApplyTheme()
        {
            this.BackColor = BakeryTheme.Cream;
            this.ForeColor = BakeryTheme.TextDark;
            this.Font = new Font(BakeryTheme.PrimaryFontFamily, BakeryTheme.BodyFontSize);
        }

        
        // I added a few sample rows so the prototype looks realistic
       
        private void LoadSampleProducts()
        {
            // Sample products for visual prototype only
            lstProducts.Items.Add("Sourdough Loaf          $8.50");
            lstProducts.Items.Add("Cinnamon Raisin Bread   $9.00");
            lstProducts.Items.Add("Chocolate Chip Cookies  $6.00");
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show(
                "This is a prototype. Adding items will be implemented in a later phase.",
                "Olive Branch Bakes",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnViewSummary_Click(object sender, EventArgs e)
        {
            var summary = new OrderSummaryForm();
            summary.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var welcome = new WelcomeForm();
            welcome.Show();
            this.Close();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            var account = new CustomerAccountForm();
            account.Show();
            this.Hide();
        }

        private void CustomerOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Keep application running if other forms are open
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstOrderItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
