using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using OliveBranchBakes.Models;
using OliveBranchBakes.Services;

namespace OliveBranchBakes.Forms
{
    public partial class OrderSummaryForm : Form
    {
        private readonly List<OrderItem> _items;
        private readonly IPricingService _pricing = new PricingService();
        private readonly ISchedulingService _scheduling = new SchedulingService();
        private readonly IOrderService _orders = new OrderService();

        public OrderSummaryForm() : this(new List<OrderItem>())
        {
        }

        public OrderSummaryForm(List<OrderItem> items)
        {
            _items = items != null
                ? items.Select(i => new OrderItem
                {
                    ProductId = i.ProductId,
                    ProductName = i.ProductName,
                    Category = i.Category,
                    Quantity = i.Quantity,
                    UnitPrice = i.UnitPrice
                }).ToList()
                : new List<OrderItem>();

            InitializeComponent();
      

            dtpPickup.MinDate = DateTime.Today.AddDays(1);
            dtpPickup.Value = DateTime.Today.AddDays(2);
            dtpPickup.ValueChanged += dtpPickup_ValueChanged;

            RefreshSummary();
        }



        private void dtpPickup_ValueChanged(object sender, EventArgs e)
        {
            RefreshSummary();
        }

        private void RefreshSummary()
        {
            lstSummary.Items.Clear();
            foreach (OrderItem item in _items)
            {
                lstSummary.Items.Add(string.Format("{0} x {1}  ${2:0.00}",
                    item.Quantity, item.ProductName, item.LineTotal));
            }

            DateTime orderDate = DateTime.Now;
            DateTime pickup = dtpPickup.Value;
            PriceBreakdown b = _pricing.GetBreakdown(_items, orderDate, pickup);

            lstSummary.Items.Add("--------------------------------");
            lstSummary.Items.Add(string.Format("Subtotal     ${0:0.00}", b.SubTotal));
            lstSummary.Items.Add(string.Format("Discount     -${0:0.00}", b.Discount));
            lstSummary.Items.Add(string.Format("Fees         ${0:0.00}", b.Fees));
            lstSummary.Items.Add(string.Format("Tax (8.5%)   ${0:0.00}", Math.Round(b.Tax, 2, MidpointRounding.AwayFromZero)));
            lstSummary.Items.Add(string.Format("TOTAL        ${0:0.00}", b.Total));

            int piesLeft = _scheduling.PiesRemainingForDate(pickup);
            lblTotals.Text = string.Format(
                "P5: discount if 7+ days out; $5 rush if under 48 hours.\r\nO1: {0} pie slot(s) left for {1:d}.",
                piesLeft, pickup.Date);
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (_items == null || _items.Count == 0)
            {
                MessageBox.Show("Your cart is empty.", "Olive Branch Bakes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DateTime pickup = dtpPickup.Value;
            string msg;
            if (!_scheduling.CanAcceptOrder(DateTime.Now, pickup, _items, out msg))
            {
                MessageBox.Show(msg, "Cannot place order",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int customerId = Session.IsSignedIn ? Session.CurrentCustomer.CustomerId : 0;
                Order order = _orders.PlaceOrder(_items, pickup, txtPickupNotes.Text, customerId);

                MessageBox.Show(
                    string.Format(
                        "Order placed!\r\nConfirmation: {0}\r\nTotal: ${1:0.00}\r\nStatus: {2}",
                        order.ConfirmationNumber, order.Total, order.Status),
                    "Olive Branch Bakes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                var welcome = new WelcomeForm();
                welcome.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cannot place order",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
