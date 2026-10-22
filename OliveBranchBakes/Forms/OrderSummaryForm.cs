using System;
using System.Drawing;
using System.Windows.Forms;
using OliveBranchBakes.Models;

namespace OliveBranchBakes.Forms
{
    public partial class OrderSummaryForm : Form
    {
        public OrderSummaryForm()
        {
            InitializeComponent();
            ApplyTheme();
            LoadSampleSummary();
        }

        private void ApplyTheme()
        {
            this.BackColor = BakeryTheme.Cream;
            this.ForeColor = BakeryTheme.TextDark;
        }

        private void LoadSampleSummary()
        {
            lstSummary.Items.Add("Sourdough Loaf  × 1          $8.50");
            lstSummary.Items.Add("Chocolate Chip Cookies × 2   $12.00");
            lstSummary.Items.Add("--------------------------------");
            lstSummary.Items.Add("Estimated Total              $20.50");
            lstSummary.Items.Add("(Pickup notes and final total in later phase)");
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Thank you! Order placement will be fully implemented in a later phase.",
                "Olive Branch Bakes",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var orderForm = new CustomerOrderForm();
            orderForm.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var welcome = new WelcomeForm();
            welcome.Show();
            this.Close();
        }
    }
}
