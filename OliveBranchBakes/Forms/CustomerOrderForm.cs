using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using OliveBranchBakes.Models;
using OliveBranchBakes.Services;

namespace OliveBranchBakes.Forms
{
    public partial class CustomerOrderForm : Form
    {
        private readonly ProductService _productService = new ProductService();
        private readonly List<OrderItem> _cart = new List<OrderItem>();
        private List<Product> _visibleProducts = new List<Product>();
        private DateTime _menuDate = DateTime.Today;
        private bool _loadingCategories;

        public CustomerOrderForm()
        {
            InitializeComponent();
            ApplyTheme();
            _menuDate = DateTime.Today;
            dtpMenuDate.Value = _menuDate;
            RefreshMenu();
            RefreshCartDisplay();
        }

        private void ApplyTheme()
        {
            this.BackColor = BakeryTheme.Cream;
            this.ForeColor = BakeryTheme.TextDark;
            this.Font = new Font(BakeryTheme.PrimaryFontFamily, BakeryTheme.BodyFontSize);
        }

        private void RefreshMenu()
        {
            LoadCategories();
            LoadProducts();
        }

        private void LoadCategories()
        {
            _loadingCategories = true;

            string previous = null;
            if (cmbCategory.SelectedItem != null)
            {
                previous = cmbCategory.SelectedItem.ToString();
            }

            cmbCategory.BeginUpdate();
            cmbCategory.Items.Clear();
            foreach (string category in _productService.GetCategories(_menuDate))
            {
                cmbCategory.Items.Add(category);
            }
            cmbCategory.EndUpdate();

            int index = 0;
            if (!string.IsNullOrEmpty(previous))
            {
                for (int i = 0; i < cmbCategory.Items.Count; i++)
                {
                    if (string.Equals(cmbCategory.Items[i].ToString(), previous, StringComparison.OrdinalIgnoreCase))
                    {
                        index = i;
                        break;
                    }
                }
            }

            if (cmbCategory.Items.Count > 0)
            {
                cmbCategory.SelectedIndex = index;
            }

            _loadingCategories = false;
        }

        private void LoadProducts()
        {
            string category = "All";
            if (cmbCategory.SelectedItem != null)
            {
                category = cmbCategory.SelectedItem.ToString();
            }

            _visibleProducts = _productService
                .GetAvailableProducts(_menuDate, category)
                .ToList();

            lstProducts.BeginUpdate();
            lstProducts.Items.Clear();
            foreach (Product product in _visibleProducts)
            {
                lstProducts.Items.Add(product.ToString());
            }

            if (_visibleProducts.Count == 0)
            {
                lstProducts.Items.Add("(No items for this category or date)");
            }
            lstProducts.EndUpdate();

            if (lblProducts != null)
            {
                lblProducts.Text = string.Format("Available ({0})", _visibleProducts.Count);
            }
        }

        private void dtpMenu_ValueChanged(object sender, EventArgs e)
        {
            _menuDate = dtpMenuDate.Value.Date;
            RefreshMenu();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_loadingCategories)
            {
                return;
            }

            LoadProducts();
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedIndex < 0 || lstProducts.SelectedIndex >= _visibleProducts.Count)
            {
                MessageBox.Show("Please select a product from the list.", "Olive Branch Bakes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int quantity = (int)nudQuantity.Value;
            if (quantity < 1)
            {
                MessageBox.Show("Quantity must be at least 1.", "Olive Branch Bakes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Product product = _visibleProducts[lstProducts.SelectedIndex];
            OrderItem existing = _cart.FirstOrDefault(i => i.ProductId == product.ProductId);

            if (existing != null)
            {
                existing.Quantity += quantity;
            }
            else
            {
                _cart.Add(new OrderItem
                {
                    ProductId = product.ProductId,
                    ProductName = product.Name,
                    UnitPrice = product.Price,
                    Quantity = quantity
                });
            }

            nudQuantity.Value = 1;
            RefreshCartDisplay();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lstOrderItems.SelectedIndex < 0 || lstOrderItems.SelectedIndex >= _cart.Count)
            {
                MessageBox.Show("Select an item in your order to remove.", "Olive Branch Bakes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _cart.RemoveAt(lstOrderItems.SelectedIndex);
            RefreshCartDisplay();
        }

        private void btnChangeQty_Click(object sender, EventArgs e)
        {
            if (lstOrderItems.SelectedIndex < 0 || lstOrderItems.SelectedIndex >= _cart.Count)
            {
                MessageBox.Show("Select an item in your order to change its quantity.", "Olive Branch Bakes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int quantity = (int)nudQuantity.Value;
            if (quantity < 1)
            {
                MessageBox.Show("Quantity must be at least 1. Use Remove to delete a line.", "Olive Branch Bakes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _cart[lstOrderItems.SelectedIndex].Quantity = quantity;
            RefreshCartDisplay();
        }

        private void RefreshCartDisplay()
        {
            lstOrderItems.Items.Clear();
            decimal subtotal = 0m;

            foreach (OrderItem item in _cart)
            {
                decimal line = item.LineTotal;
                subtotal += line;
                lstOrderItems.Items.Add(string.Format("{0} x {1}  ${2:0.00}",
                    item.Quantity, item.ProductName, line));
            }

            if (lblSubtotal != null)
            {
                lblSubtotal.Text = string.Format("Subtotal: ${0:0.00}", subtotal);
            }
        }

        private void btnViewSummary_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0)
            {
                MessageBox.Show("Your cart is empty. Add at least one item before viewing the summary.",
                    "Olive Branch Bakes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void lstOrderItems_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (_loadingCategories)
                return;

            LoadProducts();
        }
    }
}
