namespace CustomManager
{
    partial class ProductForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportSelectedProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAllProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.searchTB = new MetroFramework.Controls.MetroTextBox();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.searchBTN = new MetroFramework.Controls.MetroButton();
            this.idproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameRUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimumCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hSCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feacnidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typemoneyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typemeasureidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.metroProgressBar1);
            this.panel3.Controls.Add(this.metroProgressSpinner1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 334);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(898, 62);
            this.panel3.TabIndex = 8;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroProgressBar1.HideProgressText = false;
            this.metroProgressBar1.Location = new System.Drawing.Point(12, 27);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(874, 23);
            this.metroProgressBar1.TabIndex = 9;
            this.metroProgressBar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroProgressBar1.Visible = false;
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.BackColor = System.Drawing.Color.RoyalBlue;
            this.metroProgressSpinner1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroProgressSpinner1.EnsureVisible = false;
            this.metroProgressSpinner1.Location = new System.Drawing.Point(0, 13);
            this.metroProgressSpinner1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(49, 49);
            this.metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.White;
            this.metroProgressSpinner1.TabIndex = 0;
            this.metroProgressSpinner1.UseCustomBackColor = true;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.Value = 95;
            this.metroProgressSpinner1.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.AliceBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(898, 13);
            this.panel4.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproductDataGridViewTextBoxColumn,
            this.productNameRUDataGridViewTextBoxColumn,
            this.productNameENDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.minimumCostDataGridViewTextBoxColumn,
            this.productCodeDataGridViewTextBoxColumn,
            this.hSCodeDataGridViewTextBoxColumn,
            this.feacnidDataGridViewTextBoxColumn,
            this.shopCostDataGridViewTextBoxColumn,
            this.typemoneyidDataGridViewTextBoxColumn,
            this.measureCountDataGridViewTextBoxColumn,
            this.typemeasureidDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.Location = new System.Drawing.Point(2, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(893, 259);
            this.dataGridView1.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportSelectedProductsToolStripMenuItem,
            this.exportAllProductsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(205, 76);
            // 
            // exportSelectedProductsToolStripMenuItem
            // 
            this.exportSelectedProductsToolStripMenuItem.Name = "exportSelectedProductsToolStripMenuItem";
            this.exportSelectedProductsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.exportSelectedProductsToolStripMenuItem.Text = "Export Selected Products";
            this.exportSelectedProductsToolStripMenuItem.Click += new System.EventHandler(this.exportSelectedProductsToolStripMenuItem_Click);
            // 
            // exportAllProductsToolStripMenuItem
            // 
            this.exportAllProductsToolStripMenuItem.Name = "exportAllProductsToolStripMenuItem";
            this.exportAllProductsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.exportAllProductsToolStripMenuItem.Text = "Export All Products";
            this.exportAllProductsToolStripMenuItem.Click += new System.EventHandler(this.exportAllProductsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(201, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 72);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(892, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Products";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 13);
            this.panel2.TabIndex = 0;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel File(*.xls)|*.xls|Excel file(*.xlsx)|*.xlsx";
            // 
            // searchTB
            // 
            this.searchTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.searchTB.CustomButton.Image = null;
            this.searchTB.CustomButton.Location = new System.Drawing.Point(758, 1);
            this.searchTB.CustomButton.Name = "";
            this.searchTB.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.searchTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchTB.CustomButton.TabIndex = 1;
            this.searchTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchTB.CustomButton.UseSelectable = true;
            this.searchTB.CustomButton.Visible = false;
            this.searchTB.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.searchTB.Lines = new string[0];
            this.searchTB.Location = new System.Drawing.Point(10, 11);
            this.searchTB.MaxLength = 32767;
            this.searchTB.Name = "searchTB";
            this.searchTB.PasswordChar = '\0';
            this.searchTB.PromptText = "Search text";
            this.searchTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchTB.SelectedText = "";
            this.searchTB.SelectionLength = 0;
            this.searchTB.SelectionStart = 0;
            this.searchTB.ShortcutsEnabled = true;
            this.searchTB.Size = new System.Drawing.Size(782, 25);
            this.searchTB.TabIndex = 10;
            this.searchTB.UseSelectable = true;
            this.searchTB.WaterMark = "Search text";
            this.searchTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // filterPanel
            // 
            this.filterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.filterPanel.Controls.Add(this.searchBTN);
            this.filterPanel.Controls.Add(this.searchTB);
            this.filterPanel.Location = new System.Drawing.Point(2, 72);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(893, 52);
            this.filterPanel.TabIndex = 11;
            this.filterPanel.Visible = false;
            // 
            // searchBTN
            // 
            this.searchBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBTN.Location = new System.Drawing.Point(798, 14);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(75, 23);
            this.searchBTN.TabIndex = 16;
            this.searchBTN.Text = "Search";
            this.searchBTN.UseSelectable = true;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // idproductDataGridViewTextBoxColumn
            // 
            this.idproductDataGridViewTextBoxColumn.DataPropertyName = "id_product";
            this.idproductDataGridViewTextBoxColumn.HeaderText = "id_product";
            this.idproductDataGridViewTextBoxColumn.Name = "idproductDataGridViewTextBoxColumn";
            this.idproductDataGridViewTextBoxColumn.ReadOnly = true;
            this.idproductDataGridViewTextBoxColumn.Visible = false;
            // 
            // productNameRUDataGridViewTextBoxColumn
            // 
            this.productNameRUDataGridViewTextBoxColumn.DataPropertyName = "Product_Name_RU";
            this.productNameRUDataGridViewTextBoxColumn.HeaderText = "Name (RU)";
            this.productNameRUDataGridViewTextBoxColumn.Name = "productNameRUDataGridViewTextBoxColumn";
            this.productNameRUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameENDataGridViewTextBoxColumn
            // 
            this.productNameENDataGridViewTextBoxColumn.DataPropertyName = "Product_Name_EN";
            this.productNameENDataGridViewTextBoxColumn.HeaderText = "Name (EN)";
            this.productNameENDataGridViewTextBoxColumn.Name = "productNameENDataGridViewTextBoxColumn";
            this.productNameENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight (kg)";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // minimumCostDataGridViewTextBoxColumn
            // 
            this.minimumCostDataGridViewTextBoxColumn.DataPropertyName = "Minimum_Cost";
            this.minimumCostDataGridViewTextBoxColumn.HeaderText = "Minimum Cost (USD)";
            this.minimumCostDataGridViewTextBoxColumn.Name = "minimumCostDataGridViewTextBoxColumn";
            this.minimumCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "Product_Code";
            this.productCodeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            this.productCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hSCodeDataGridViewTextBoxColumn
            // 
            this.hSCodeDataGridViewTextBoxColumn.DataPropertyName = "HSCode";
            this.hSCodeDataGridViewTextBoxColumn.HeaderText = "HSCode";
            this.hSCodeDataGridViewTextBoxColumn.Name = "hSCodeDataGridViewTextBoxColumn";
            this.hSCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // feacnidDataGridViewTextBoxColumn
            // 
            this.feacnidDataGridViewTextBoxColumn.DataPropertyName = "feacn_id";
            this.feacnidDataGridViewTextBoxColumn.HeaderText = "FEACN code";
            this.feacnidDataGridViewTextBoxColumn.Name = "feacnidDataGridViewTextBoxColumn";
            this.feacnidDataGridViewTextBoxColumn.ReadOnly = true;
            this.feacnidDataGridViewTextBoxColumn.Visible = false;
            // 
            // shopCostDataGridViewTextBoxColumn
            // 
            this.shopCostDataGridViewTextBoxColumn.DataPropertyName = "Shop_Cost";
            this.shopCostDataGridViewTextBoxColumn.HeaderText = "Shop_Cost";
            this.shopCostDataGridViewTextBoxColumn.Name = "shopCostDataGridViewTextBoxColumn";
            this.shopCostDataGridViewTextBoxColumn.ReadOnly = true;
            this.shopCostDataGridViewTextBoxColumn.Visible = false;
            // 
            // typemoneyidDataGridViewTextBoxColumn
            // 
            this.typemoneyidDataGridViewTextBoxColumn.DataPropertyName = "type_money_id";
            this.typemoneyidDataGridViewTextBoxColumn.HeaderText = "type_money_id";
            this.typemoneyidDataGridViewTextBoxColumn.Name = "typemoneyidDataGridViewTextBoxColumn";
            this.typemoneyidDataGridViewTextBoxColumn.ReadOnly = true;
            this.typemoneyidDataGridViewTextBoxColumn.Visible = false;
            // 
            // measureCountDataGridViewTextBoxColumn
            // 
            this.measureCountDataGridViewTextBoxColumn.DataPropertyName = "Measure_Count";
            this.measureCountDataGridViewTextBoxColumn.HeaderText = "Measure_Count";
            this.measureCountDataGridViewTextBoxColumn.Name = "measureCountDataGridViewTextBoxColumn";
            this.measureCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.measureCountDataGridViewTextBoxColumn.Visible = false;
            // 
            // typemeasureidDataGridViewTextBoxColumn
            // 
            this.typemeasureidDataGridViewTextBoxColumn.DataPropertyName = "type_measure_id";
            this.typemeasureidDataGridViewTextBoxColumn.HeaderText = "type_measure_id";
            this.typemeasureidDataGridViewTextBoxColumn.Name = "typemeasureidDataGridViewTextBoxColumn";
            this.typemeasureidDataGridViewTextBoxColumn.ReadOnly = true;
            this.typemeasureidDataGridViewTextBoxColumn.Visible = false;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(CustomManager.Product);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(898, 396);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.filterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem exportSelectedProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAllProductsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MetroFramework.Controls.MetroTextBox searchTB;
        private System.Windows.Forms.Panel filterPanel;
        private MetroFramework.Controls.MetroButton searchBTN;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameRUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimumCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hSCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feacnidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typemoneyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measureCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typemeasureidDataGridViewTextBoxColumn;
    }
}