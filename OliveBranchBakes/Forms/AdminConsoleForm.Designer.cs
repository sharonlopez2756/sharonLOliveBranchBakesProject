namespace OliveBranchBakes.Forms
{
    partial class AdminConsoleForm
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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.grpCurrentOrder = new System.Windows.Forms.GroupBox();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lblOrderCount = new System.Windows.Forms.Label();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.grpCurrentOrder.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Fuchsia;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Script MT Bold", 8.25F);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(231)))));
            this.btnHome.Location = new System.Drawing.Point(135, 379);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(81, 26);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Script MT Bold", 8.25F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(29, 316);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 26);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Script MT Bold", 8.25F);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(231)))));
            this.btnLogout.Location = new System.Drawing.Point(29, 380);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 25);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OliveBranchBakes.Properties.Resources.adminconsolepic;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.LightPink;
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(681, 48);
            this.pnlHeader.TabIndex = 0;
            // 
            // grpCurrentOrder
            // 
            this.grpCurrentOrder.Controls.Add(this.lstOrders);
            this.grpCurrentOrder.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCurrentOrder.ForeColor = System.Drawing.Color.Fuchsia;
            this.grpCurrentOrder.Location = new System.Drawing.Point(12, 91);
            this.grpCurrentOrder.Margin = new System.Windows.Forms.Padding(2);
            this.grpCurrentOrder.Name = "grpCurrentOrder";
            this.grpCurrentOrder.Padding = new System.Windows.Forms.Padding(2);
            this.grpCurrentOrder.Size = new System.Drawing.Size(306, 211);
            this.grpCurrentOrder.TabIndex = 7;
            this.grpCurrentOrder.TabStop = false;
            this.grpCurrentOrder.Text = "Orders";
            // 
            // lstOrders
            // 
            this.lstOrders.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.ItemHeight = 17;
            this.lstOrders.Location = new System.Drawing.Point(17, 23);
            this.lstOrders.Margin = new System.Windows.Forms.Padding(2);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(260, 174);
            this.lstOrders.TabIndex = 0;
            this.lstOrders.SelectedIndexChanged += new System.EventHandler(this.lstOrders_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDetails);
            this.groupBox1.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox1.Location = new System.Drawing.Point(348, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(306, 211);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(16, 24);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(258, 174);
            this.txtDetails.TabIndex = 0;
            // 
            // lblOrderCount
            // 
            this.lblOrderCount.AutoSize = true;
            this.lblOrderCount.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderCount.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblOrderCount.Location = new System.Drawing.Point(11, 60);
            this.lblOrderCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderCount.Name = "lblOrderCount";
            this.lblOrderCount.Size = new System.Drawing.Size(53, 19);
            this.lblOrderCount.TabIndex = 16;
            this.lblOrderCount.Text = "Count: ";
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpdateStatus.FlatAppearance.BorderSize = 0;
            this.btnUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStatus.Font = new System.Drawing.Font("Script MT Bold", 8.25F);
            this.btnUpdateStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(231)))));
            this.btnUpdateStatus.Location = new System.Drawing.Point(572, 334);
            this.btnUpdateStatus.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(82, 23);
            this.btnUpdateStatus.TabIndex = 17;
            this.btnUpdateStatus.Text = "Update";
            this.btnUpdateStatus.UseVisualStyleBackColor = false;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(423, 334);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(134, 21);
            this.cmbStatus.TabIndex = 18;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblStatus.Location = new System.Drawing.Point(360, 334);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 19);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Status:";
            // 
            // AdminConsoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(681, 416);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.lblOrderCount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpCurrentOrder);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AdminConsoleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olive Branch Bakes – Admin Console";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.grpCurrentOrder.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.GroupBox grpCurrentOrder;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblOrderCount;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
    }
}
