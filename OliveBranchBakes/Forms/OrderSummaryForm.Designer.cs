namespace OliveBranchBakes.Forms
{
    partial class OrderSummaryForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lstSummary = new System.Windows.Forms.ListBox();
            this.lblPickup = new System.Windows.Forms.Label();
            this.txtPickupNotes = new System.Windows.Forms.TextBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblPickupDate = new System.Windows.Forms.Label();
            this.dtpPickup = new System.Windows.Forms.DateTimePicker();
            this.lblTotals = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(107)))), ((int)(((byte)(47)))));
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(633, 42);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(231)))));
            this.lblHeader.Location = new System.Drawing.Point(12, 10);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(162, 28);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Order Summary";
            // 
            // lstSummary
            // 
            this.lstSummary.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lstSummary.FormattingEnabled = true;
            this.lstSummary.ItemHeight = 20;
            this.lstSummary.Location = new System.Drawing.Point(21, 57);
            this.lstSummary.Margin = new System.Windows.Forms.Padding(2);
            this.lstSummary.Name = "lstSummary";
            this.lstSummary.Size = new System.Drawing.Size(346, 124);
            this.lstSummary.TabIndex = 1;
            // 
            // lblPickup
            // 
            this.lblPickup.AutoSize = true;
            this.lblPickup.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPickup.Location = new System.Drawing.Point(404, 57);
            this.lblPickup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPickup.Name = "lblPickup";
            this.lblPickup.Size = new System.Drawing.Size(168, 20);
            this.lblPickup.TabIndex = 2;
            this.lblPickup.Text = "Pickup Notes (optional):";
            // 
            // txtPickupNotes
            // 
            this.txtPickupNotes.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPickupNotes.Location = new System.Drawing.Point(408, 101);
            this.txtPickupNotes.Margin = new System.Windows.Forms.Padding(2);
            this.txtPickupNotes.Multiline = true;
            this.txtPickupNotes.Name = "txtPickupNotes";
            this.txtPickupNotes.Size = new System.Drawing.Size(214, 278);
            this.txtPickupNotes.TabIndex = 3;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(107)))), ((int)(((byte)(47)))));
            this.btnPlaceOrder.FlatAppearance.BorderSize = 0;
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(231)))));
            this.btnPlaceOrder.Location = new System.Drawing.Point(21, 292);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(345, 41);
            this.btnPlaceOrder.TabIndex = 4;
            this.btnPlaceOrder.Text = "Confirm and Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(32)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.btnBack.Location = new System.Drawing.Point(21, 345);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 34);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "← Edit Order";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(90)))), ((int)(((byte)(43)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(231)))));
            this.btnHome.Location = new System.Drawing.Point(216, 345);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(150, 34);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblPickupDate
            // 
            this.lblPickupDate.AutoSize = true;
            this.lblPickupDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPickupDate.Location = new System.Drawing.Point(141, 194);
            this.lblPickupDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPickupDate.Name = "lblPickupDate";
            this.lblPickupDate.Size = new System.Drawing.Size(86, 20);
            this.lblPickupDate.TabIndex = 7;
            this.lblPickupDate.Text = "Pickup date";
            // 
            // dtpPickup
            // 
            this.dtpPickup.Location = new System.Drawing.Point(81, 217);
            this.dtpPickup.Name = "dtpPickup";
            this.dtpPickup.Size = new System.Drawing.Size(200, 20);
            this.dtpPickup.TabIndex = 8;
            // 
            // lblTotals
            // 
            this.lblTotals.AutoSize = true;
            this.lblTotals.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTotals.Location = new System.Drawing.Point(77, 253);
            this.lblTotals.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotals.Name = "lblTotals";
            this.lblTotals.Size = new System.Drawing.Size(0, 20);
            this.lblTotals.TabIndex = 9;
            // 
            // OrderSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 398);
            this.Controls.Add(this.lblTotals);
            this.Controls.Add(this.dtpPickup);
            this.Controls.Add(this.lblPickupDate);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.txtPickupNotes);
            this.Controls.Add(this.lblPickup);
            this.Controls.Add(this.lstSummary);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "OrderSummaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olive Branch Bakes – Order Summary";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ListBox lstSummary;
        private System.Windows.Forms.Label lblPickup;
        private System.Windows.Forms.TextBox txtPickupNotes;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblPickupDate;
        private System.Windows.Forms.DateTimePicker dtpPickup;
        private System.Windows.Forms.Label lblTotals;
    }
}
