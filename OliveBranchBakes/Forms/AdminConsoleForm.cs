using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OliveBranchBakes.Models;
using OliveBranchBakes.Services;

namespace OliveBranchBakes.Forms
{
    public partial class AdminConsoleForm : Form
    {
        private readonly IAdminService _admins = new AdminService();
        private List<Order> _orders = new List<Order>();

        public AdminConsoleForm()
        {
            InitializeComponent();
            LoadStatuses();
            RefreshOrders();
        }

        private void LoadStatuses()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Received");
            cmbStatus.Items.Add("In Progress");
            cmbStatus.Items.Add("Ready");
            cmbStatus.Items.Add("Picked Up");
            cmbStatus.Items.Add("Cancelled");
            if (cmbStatus.Items.Count > 0)
                cmbStatus.SelectedIndex = 0;
        }

        private void RefreshOrders()
        {
            _orders = _admins.GetAllOrders().ToList();
            lstOrders.Items.Clear();

            foreach (Order o in _orders)
            {
                lstOrders.Items.Add(string.Format(
                    "#{0}  {1}  {2}  ${3:0.00}",
                    o.OrderId,
                    o.ConfirmationNumber,
                    o.Status,
                    o.Total));
            }

            lblOrderCount.Text = "Orders: " + _orders.Count;
        }

        private void lstOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOrders.SelectedIndex < 0 || lstOrders.SelectedIndex >= _orders.Count)
            {
                txtDetails.Text = "";
                return;
            }

            Order o = _orders[lstOrders.SelectedIndex];

            txtDetails.Text =
                "Confirmation: " + o.ConfirmationNumber + "\r\n" +
                "Status: " + o.Status + "\r\n" +
                "CustomerId: " + o.CustomerId + "\r\n" +
                "Order date: " + o.OrderDate.ToString("g") + "\r\n" +
                "Pickup: " + (o.PickupDate.HasValue ? o.PickupDate.Value.ToString("g") : "-") + "\r\n" +
                "Total: $" + o.Total.ToString("0.00");
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (lstOrders.SelectedIndex < 0 || lstOrders.SelectedIndex >= _orders.Count)
            {
                MessageBox.Show("Click an order in the list first.");
                return;
            }

            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Choose a status.");
                return;
            }

            Order o = _orders[lstOrders.SelectedIndex];
            string status = cmbStatus.SelectedItem.ToString();
            string message;

            if (_admins.UpdateOrderStatus(o.OrderId, status, out message))
            {
                MessageBox.Show(message);
                RefreshOrders();
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshOrders();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.SignOutAdmin();
            new AdminLoginForm().Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Session.SignOutAdmin();
            new WelcomeForm().Show();
            this.Close();
        }
    }
}
