namespace CustomManager
{
    partial class FEACNForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportSelectedOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAllOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.searchBTN = new MetroFramework.Controls.MetroButton();
            this.searchTB = new MetroFramework.Controls.MetroTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.idfeacnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fEACNNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aksizpersentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poshlinapersentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qQSpersentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fEACNCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fEACNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fEACNBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 72);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(944, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "FEACN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 13);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.metroProgressBar1);
            this.panel3.Controls.Add(this.metroProgressSpinner1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 326);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(950, 62);
            this.panel3.TabIndex = 11;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroProgressBar1.HideProgressText = false;
            this.metroProgressBar1.Location = new System.Drawing.Point(12, 27);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(926, 23);
            this.metroProgressBar1.TabIndex = 6;
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
            this.panel4.Size = new System.Drawing.Size(950, 13);
            this.panel4.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfeacnDataGridViewTextBoxColumn,
            this.fEACNNameDataGridViewTextBoxColumn,
            this.aksizpersentDataGridViewTextBoxColumn,
            this.poshlinapersentDataGridViewTextBoxColumn,
            this.qQSpersentDataGridViewTextBoxColumn,
            this.fEACNCodeDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.fEACNBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.Location = new System.Drawing.Point(1, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(947, 251);
            this.dataGridView1.TabIndex = 12;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportSelectedOrdersToolStripMenuItem,
            this.exportAllOrdersToolStripMenuItem,
            this.toolStripMenuItem1,
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 76);
            // 
            // exportSelectedOrdersToolStripMenuItem
            // 
            this.exportSelectedOrdersToolStripMenuItem.Name = "exportSelectedOrdersToolStripMenuItem";
            this.exportSelectedOrdersToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exportSelectedOrdersToolStripMenuItem.Text = "Export selected";
            this.exportSelectedOrdersToolStripMenuItem.Click += new System.EventHandler(this.exportSelectedOrdersToolStripMenuItem_Click);
            // 
            // exportAllOrdersToolStripMenuItem
            // 
            this.exportAllOrdersToolStripMenuItem.Name = "exportAllOrdersToolStripMenuItem";
            this.exportAllOrdersToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exportAllOrdersToolStripMenuItem.Text = "Export All";
            this.exportAllOrdersToolStripMenuItem.Click += new System.EventHandler(this.exportAllOrdersToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel(*.xls)|*.xls|Excel(*.xlsx)|*.xlsx";
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
            this.filterPanel.Size = new System.Drawing.Size(945, 52);
            this.filterPanel.TabIndex = 13;
            this.filterPanel.Visible = false;
            // 
            // searchBTN
            // 
            this.searchBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBTN.Location = new System.Drawing.Point(850, 14);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(75, 23);
            this.searchBTN.TabIndex = 16;
            this.searchBTN.Text = "Search";
            this.searchBTN.UseSelectable = true;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // searchTB
            // 
            this.searchTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.searchTB.CustomButton.Image = null;
            this.searchTB.CustomButton.Location = new System.Drawing.Point(810, 1);
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
            this.searchTB.Size = new System.Drawing.Size(834, 25);
            this.searchTB.TabIndex = 10;
            this.searchTB.UseSelectable = true;
            this.searchTB.WaterMark = "Search text";
            this.searchTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idfeacnDataGridViewTextBoxColumn
            // 
            this.idfeacnDataGridViewTextBoxColumn.DataPropertyName = "id_feacn";
            this.idfeacnDataGridViewTextBoxColumn.HeaderText = "id_feacn";
            this.idfeacnDataGridViewTextBoxColumn.Name = "idfeacnDataGridViewTextBoxColumn";
            this.idfeacnDataGridViewTextBoxColumn.ReadOnly = true;
            this.idfeacnDataGridViewTextBoxColumn.Visible = false;
            // 
            // fEACNNameDataGridViewTextBoxColumn
            // 
            this.fEACNNameDataGridViewTextBoxColumn.DataPropertyName = "FEACN_Name";
            this.fEACNNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.fEACNNameDataGridViewTextBoxColumn.Name = "fEACNNameDataGridViewTextBoxColumn";
            this.fEACNNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aksizpersentDataGridViewTextBoxColumn
            // 
            this.aksizpersentDataGridViewTextBoxColumn.DataPropertyName = "Aksiz_persent";
            this.aksizpersentDataGridViewTextBoxColumn.HeaderText = "Aksiz (%)";
            this.aksizpersentDataGridViewTextBoxColumn.Name = "aksizpersentDataGridViewTextBoxColumn";
            this.aksizpersentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // poshlinapersentDataGridViewTextBoxColumn
            // 
            this.poshlinapersentDataGridViewTextBoxColumn.DataPropertyName = "Poshlina_persent";
            this.poshlinapersentDataGridViewTextBoxColumn.HeaderText = "Poshlina (%)";
            this.poshlinapersentDataGridViewTextBoxColumn.Name = "poshlinapersentDataGridViewTextBoxColumn";
            this.poshlinapersentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qQSpersentDataGridViewTextBoxColumn
            // 
            this.qQSpersentDataGridViewTextBoxColumn.DataPropertyName = "QQS_persent";
            this.qQSpersentDataGridViewTextBoxColumn.HeaderText = "QQS (%)";
            this.qQSpersentDataGridViewTextBoxColumn.Name = "qQSpersentDataGridViewTextBoxColumn";
            this.qQSpersentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fEACNCodeDataGridViewTextBoxColumn
            // 
            this.fEACNCodeDataGridViewTextBoxColumn.DataPropertyName = "FEACN_Code";
            this.fEACNCodeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.fEACNCodeDataGridViewTextBoxColumn.Name = "fEACNCodeDataGridViewTextBoxColumn";
            this.fEACNCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fEACNBindingSource
            // 
            this.fEACNBindingSource.DataSource = typeof(CustomManager.FEACN);
            // 
            // FEACNForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(950, 388);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FEACNForm";
            this.Load += new System.EventHandler(this.FEACNForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.filterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fEACNBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportSelectedOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAllOrdersToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.Windows.Forms.BindingSource fEACNBindingSource;
        private System.Windows.Forms.Panel filterPanel;
        private MetroFramework.Controls.MetroButton searchBTN;
        private MetroFramework.Controls.MetroTextBox searchTB;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfeacnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fEACNNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aksizpersentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poshlinapersentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qQSpersentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fEACNCodeDataGridViewTextBoxColumn;
        //private System.Windows.Forms.BindingSource myProductBindingSource;
    }
}