namespace CustomManager
{
    partial class AddContractForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTP = new System.Windows.Forms.DateTimePicker();
            this.okBTN = new System.Windows.Forms.Button();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.descriptionTB = new System.Windows.Forms.TextBox();
            this.addOrderLL = new System.Windows.Forms.LinkLabel();
            this.clearOrderLL = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionSendingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionOriginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addContractViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addContractViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Date:";
            // 
            // dateTP
            // 
            this.dateTP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTP.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTP.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTP.Enabled = false;
            this.dateTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTP.Location = new System.Drawing.Point(127, 63);
            this.dateTP.Name = "dateTP";
            this.dateTP.ShowCheckBox = true;
            this.dateTP.Size = new System.Drawing.Size(931, 26);
            this.dateTP.TabIndex = 15;
            // 
            // okBTN
            // 
            this.okBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okBTN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.okBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.okBTN.Location = new System.Drawing.Point(56, 418);
            this.okBTN.Name = "okBTN";
            this.okBTN.Size = new System.Drawing.Size(100, 38);
            this.okBTN.TabIndex = 18;
            this.okBTN.Text = "&OK";
            this.okBTN.UseVisualStyleBackColor = false;
            this.okBTN.Click += new System.EventHandler(this.okBTN_Click);
            // 
            // cancelBTN
            // 
            this.cancelBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBTN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cancelBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelBTN.Location = new System.Drawing.Point(917, 418);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(100, 38);
            this.cancelBTN.TabIndex = 19;
            this.cancelBTN.Text = "&Cancel";
            this.cancelBTN.UseVisualStyleBackColor = false;
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroProgressSpinner1.BackColor = System.Drawing.Color.RoyalBlue;
            this.metroProgressSpinner1.EnsureVisible = false;
            this.metroProgressSpinner1.Location = new System.Drawing.Point(0, 417);
            this.metroProgressSpinner1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(49, 49);
            this.metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.White;
            this.metroProgressSpinner1.TabIndex = 20;
            this.metroProgressSpinner1.UseCustomBackColor = true;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.Value = 95;
            this.metroProgressSpinner1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productDataGridViewTextBoxColumn,
            this.regionSendingDataGridViewTextBoxColumn,
            this.regionOriginDataGridViewTextBoxColumn,
            this.orderCountDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.locationidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.addContractViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1042, 279);
            this.dataGridView1.TabIndex = 21;
            // 
            // descriptionTB
            // 
            this.descriptionTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTB.Location = new System.Drawing.Point(127, 26);
            this.descriptionTB.Multiline = true;
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.Size = new System.Drawing.Size(931, 30);
            this.descriptionTB.TabIndex = 23;
            this.descriptionTB.TextChanged += new System.EventHandler(this.descriptionTB_TextChanged);
            // 
            // addOrderLL
            // 
            this.addOrderLL.AutoSize = true;
            this.addOrderLL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOrderLL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addOrderLL.LinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addOrderLL.Location = new System.Drawing.Point(12, 107);
            this.addOrderLL.Name = "addOrderLL";
            this.addOrderLL.Size = new System.Drawing.Size(79, 20);
            this.addOrderLL.TabIndex = 24;
            this.addOrderLL.TabStop = true;
            this.addOrderLL.Text = "Add order";
            this.addOrderLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLinkLabel_LinkClicked);
            // 
            // clearOrderLL
            // 
            this.clearOrderLL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearOrderLL.AutoSize = true;
            this.clearOrderLL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearOrderLL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearOrderLL.LinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearOrderLL.Location = new System.Drawing.Point(974, 107);
            this.clearOrderLL.Name = "clearOrderLL";
            this.clearOrderLL.Size = new System.Drawing.Size(87, 20);
            this.clearOrderLL.TabIndex = 25;
            this.clearOrderLL.TabStop = true;
            this.clearOrderLL.Text = "Clear order";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regionSendingDataGridViewTextBoxColumn
            // 
            this.regionSendingDataGridViewTextBoxColumn.DataPropertyName = "Region_Sending";
            this.regionSendingDataGridViewTextBoxColumn.HeaderText = "Region_Sending";
            this.regionSendingDataGridViewTextBoxColumn.Name = "regionSendingDataGridViewTextBoxColumn";
            this.regionSendingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regionOriginDataGridViewTextBoxColumn
            // 
            this.regionOriginDataGridViewTextBoxColumn.DataPropertyName = "Region_Origin";
            this.regionOriginDataGridViewTextBoxColumn.HeaderText = "Region_Origin";
            this.regionOriginDataGridViewTextBoxColumn.Name = "regionOriginDataGridViewTextBoxColumn";
            this.regionOriginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderCountDataGridViewTextBoxColumn
            // 
            this.orderCountDataGridViewTextBoxColumn.DataPropertyName = "Order_Count";
            this.orderCountDataGridViewTextBoxColumn.HeaderText = "Order_Count";
            this.orderCountDataGridViewTextBoxColumn.Name = "orderCountDataGridViewTextBoxColumn";
            this.orderCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "product_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "product_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // locationidDataGridViewTextBoxColumn
            // 
            this.locationidDataGridViewTextBoxColumn.DataPropertyName = "location_id";
            this.locationidDataGridViewTextBoxColumn.HeaderText = "location_id";
            this.locationidDataGridViewTextBoxColumn.Name = "locationidDataGridViewTextBoxColumn";
            this.locationidDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationidDataGridViewTextBoxColumn.Visible = false;
            // 
            // addContractViewBindingSource
            // 
            this.addContractViewBindingSource.DataSource = typeof(CustomManager.AddContractView);
            // 
            // AddContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1074, 468);
            this.Controls.Add(this.clearOrderLL);
            this.Controls.Add(this.addOrderLL);
            this.Controls.Add(this.descriptionTB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.okBTN);
            this.Controls.Add(this.dateTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "AddContractForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addContractViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTP;
        private System.Windows.Forms.Button okBTN;
        private System.Windows.Forms.Button cancelBTN;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox descriptionTB;
        private System.Windows.Forms.LinkLabel addOrderLL;
        private System.Windows.Forms.LinkLabel clearOrderLL;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionSendingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionOriginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource addContractViewBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}