namespace OliveBranchBakes.Forms
{
    partial class CustomerOrderForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.grpCurrentOrder = new System.Windows.Forms.GroupBox();
            this.lstOrderItems = new System.Windows.Forms.ListBox();
            this.btnViewSummary = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpMenuDate = new System.Windows.Forms.DateTimePicker();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnChangeQty = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.grpCurrentOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.LightPink;
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(652, 46);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblProducts.Location = new System.Drawing.Point(15, 114);
            this.lblProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(112, 18);
            this.lblProducts.TabIndex = 1;
            this.lblProducts.Text = "Available Today";
            // 
            // lstProducts
            // 
            this.lstProducts.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 20;
            this.lstProducts.Location = new System.Drawing.Point(18, 137);
            this.lstProducts.Margin = new System.Windows.Forms.Padding(2);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(256, 204);
            this.lstProducts.TabIndex = 2;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.DeepPink;
            this.lblQuantity.Location = new System.Drawing.Point(9, 368);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(67, 19);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity:";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nudQuantity.Location = new System.Drawing.Point(80, 365);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(60, 29);
            this.nudQuantity.TabIndex = 4;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.BackColor = System.Drawing.Color.Fuchsia;
            this.btnAddToOrder.FlatAppearance.BorderSize = 0;
            this.btnAddToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToOrder.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddToOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddToOrder.Location = new System.Drawing.Point(156, 361);
            this.btnAddToOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(118, 34);
            this.btnAddToOrder.TabIndex = 5;
            this.btnAddToOrder.Text = "Add to Order";
            this.btnAddToOrder.UseVisualStyleBackColor = false;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // grpCurrentOrder
            // 
            this.grpCurrentOrder.Controls.Add(this.lstOrderItems);
            this.grpCurrentOrder.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCurrentOrder.ForeColor = System.Drawing.Color.Fuchsia;
            this.grpCurrentOrder.Location = new System.Drawing.Point(307, 114);
            this.grpCurrentOrder.Margin = new System.Windows.Forms.Padding(2);
            this.grpCurrentOrder.Name = "grpCurrentOrder";
            this.grpCurrentOrder.Padding = new System.Windows.Forms.Padding(2);
            this.grpCurrentOrder.Size = new System.Drawing.Size(306, 211);
            this.grpCurrentOrder.TabIndex = 6;
            this.grpCurrentOrder.TabStop = false;
            this.grpCurrentOrder.Text = "Your Order";
            // 
            // lstOrderItems
            // 
            this.lstOrderItems.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstOrderItems.FormattingEnabled = true;
            this.lstOrderItems.ItemHeight = 17;
            this.lstOrderItems.Location = new System.Drawing.Point(15, 24);
            this.lstOrderItems.Margin = new System.Windows.Forms.Padding(2);
            this.lstOrderItems.Name = "lstOrderItems";
            this.lstOrderItems.Size = new System.Drawing.Size(260, 174);
            this.lstOrderItems.TabIndex = 0;
            this.lstOrderItems.SelectedIndexChanged += new System.EventHandler(this.lstOrderItems_SelectedIndexChanged);
            // 
            // btnViewSummary
            // 
            this.btnViewSummary.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnViewSummary.FlatAppearance.BorderSize = 0;
            this.btnViewSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSummary.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnViewSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(231)))));
            this.btnViewSummary.Location = new System.Drawing.Point(342, 410);
            this.btnViewSummary.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewSummary.Name = "btnViewSummary";
            this.btnViewSummary.Size = new System.Drawing.Size(225, 39);
            this.btnViewSummary.TabIndex = 7;
            this.btnViewSummary.Text = "Review Order Summary";
            this.btnViewSummary.UseVisualStyleBackColor = false;
            this.btnViewSummary.Click += new System.EventHandler(this.btnViewSummary_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(231)))));
            this.btnBack.Location = new System.Drawing.Point(35, 410);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 39);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "← Back Home";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.btnAccount.Location = new System.Drawing.Point(149, 410);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(105, 39);
            this.btnAccount.TabIndex = 9;
            this.btnAccount.Text = "My Account";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(110, 62);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(127, 21);
            this.cmbCategory.TabIndex = 10;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            this.label1.Location = new System.Drawing.Point(318, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 12;
            // 
            // dtpMenuDate
            // 
            this.dtpMenuDate.Location = new System.Drawing.Point(440, 63);
            this.dtpMenuDate.Name = "dtpMenuDate";
            this.dtpMenuDate.Size = new System.Drawing.Size(200, 20);
            this.dtpMenuDate.TabIndex = 14;
            this.dtpMenuDate.ValueChanged += new System.EventHandler(this.dtpMenu_ValueChanged);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblSubtotal.Location = new System.Drawing.Point(318, 327);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(73, 19);
            this.lblSubtotal.TabIndex = 15;
            this.lblSubtotal.Text = "Subtotal:  ";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.Fuchsia;
            this.btnRemoveItem.FlatAppearance.BorderSize = 0;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItem.Location = new System.Drawing.Point(322, 361);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(124, 31);
            this.btnRemoveItem.TabIndex = 16;
            this.btnRemoveItem.Text = "Remove  Item";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnChangeQty
            // 
            this.btnChangeQty.BackColor = System.Drawing.Color.Fuchsia;
            this.btnChangeQty.FlatAppearance.BorderSize = 0;
            this.btnChangeQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeQty.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnChangeQty.ForeColor = System.Drawing.Color.White;
            this.btnChangeQty.Location = new System.Drawing.Point(474, 361);
            this.btnChangeQty.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeQty.Name = "btnChangeQty";
            this.btnChangeQty.Size = new System.Drawing.Size(124, 31);
            this.btnChangeQty.TabIndex = 17;
            this.btnChangeQty.Text = "Update Qty";
            this.btnChangeQty.UseVisualStyleBackColor = false;
            this.btnChangeQty.Click += new System.EventHandler(this.btnChangeQty_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::OliveBranchBakes.Properties.Resources.menudayofpicture;
            this.pictureBox3.Location = new System.Drawing.Point(307, 62);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(121, 31);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OliveBranchBakes.Properties.Resources.category;
            this.pictureBox2.Location = new System.Drawing.Point(18, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 31);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightPink;
            this.pictureBox1.Image = global::OliveBranchBakes.Properties.Resources.yourordertitletextPROPERSIZE;
            this.pictureBox1.Location = new System.Drawing.Point(18, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CustomerOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(652, 469);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnChangeQty);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.dtpMenuDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewSummary);
            this.Controls.Add(this.grpCurrentOrder);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "CustomerOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu as of:";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerOrderForm_FormClosed);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.grpCurrentOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.GroupBox grpCurrentOrder;
        private System.Windows.Forms.ListBox lstOrderItems;
        private System.Windows.Forms.Button btnViewSummary;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpMenuDate;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnChangeQty;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
