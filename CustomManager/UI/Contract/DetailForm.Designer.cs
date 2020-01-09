namespace CustomManager
{
    partial class DetailForm
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
            this.productPanel = new System.Windows.Forms.Panel();
            this.weightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.plModel = new System.Windows.Forms.PlaceholderTextBox();
            this.costCombobox = new System.Windows.Forms.ComboBox();
            this.costNumericUpdown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.countCombobox = new System.Windows.Forms.ComboBox();
            this.countNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.plNameEN = new System.Windows.Forms.PlaceholderTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.plNameRU = new System.Windows.Forms.PlaceholderTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.plHSCode = new System.Windows.Forms.PlaceholderTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plCode = new System.Windows.Forms.PlaceholderTextBox();
            this.customerPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.surnamePL = new System.Windows.Forms.PlaceholderTextBox();
            this.namePL = new System.Windows.Forms.PlaceholderTextBox();
            this.passwordPL = new System.Windows.Forms.PlaceholderTextBox();
            this.loginPL = new System.Windows.Forms.PlaceholderTextBox();
            this.locationPanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label17 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addressPL = new System.Windows.Forms.PlaceholderTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.longitudePL = new System.Windows.Forms.PlaceholderTextBox();
            this.latitudePL = new System.Windows.Forms.PlaceholderTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.productPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costNumericUpdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).BeginInit();
            this.customerPanel.SuspendLayout();
            this.locationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productPanel
            // 
            this.productPanel.BackColor = System.Drawing.Color.Transparent;
            this.productPanel.Controls.Add(this.weightNumericUpDown);
            this.productPanel.Controls.Add(this.label8);
            this.productPanel.Controls.Add(this.plModel);
            this.productPanel.Controls.Add(this.costCombobox);
            this.productPanel.Controls.Add(this.costNumericUpdown);
            this.productPanel.Controls.Add(this.label7);
            this.productPanel.Controls.Add(this.label6);
            this.productPanel.Controls.Add(this.countCombobox);
            this.productPanel.Controls.Add(this.countNumericUpDown);
            this.productPanel.Controls.Add(this.label5);
            this.productPanel.Controls.Add(this.label4);
            this.productPanel.Controls.Add(this.plNameEN);
            this.productPanel.Controls.Add(this.label3);
            this.productPanel.Controls.Add(this.plNameRU);
            this.productPanel.Controls.Add(this.label2);
            this.productPanel.Controls.Add(this.plHSCode);
            this.productPanel.Controls.Add(this.label1);
            this.productPanel.Controls.Add(this.plCode);
            this.productPanel.Location = new System.Drawing.Point(0, 0);
            this.productPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(494, 359);
            this.productPanel.TabIndex = 0;
            // 
            // weightNumericUpDown
            // 
            this.weightNumericUpDown.Location = new System.Drawing.Point(169, 217);
            this.weightNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.weightNumericUpDown.Name = "weightNumericUpDown";
            this.weightNumericUpDown.ReadOnly = true;
            this.weightNumericUpDown.Size = new System.Drawing.Size(291, 26);
            this.weightNumericUpDown.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.AliceBlue;
            this.label8.Location = new System.Drawing.Point(16, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "Model:";
            // 
            // plModel
            // 
            this.plModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plModel.Location = new System.Drawing.Point(169, 299);
            this.plModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plModel.Name = "plModel";
            this.plModel.PlaceholderText = "Model";
            this.plModel.ReadOnly = true;
            this.plModel.Size = new System.Drawing.Size(292, 26);
            this.plModel.TabIndex = 47;
            // 
            // costCombobox
            // 
            this.costCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.costCombobox.FormattingEnabled = true;
            this.costCombobox.Location = new System.Drawing.Point(275, 257);
            this.costCombobox.Name = "costCombobox";
            this.costCombobox.Size = new System.Drawing.Size(186, 28);
            this.costCombobox.TabIndex = 46;
            // 
            // costNumericUpdown
            // 
            this.costNumericUpdown.Location = new System.Drawing.Point(169, 258);
            this.costNumericUpdown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.costNumericUpdown.Name = "costNumericUpdown";
            this.costNumericUpdown.ReadOnly = true;
            this.costNumericUpdown.Size = new System.Drawing.Size(80, 26);
            this.costNumericUpdown.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.AliceBlue;
            this.label7.Location = new System.Drawing.Point(16, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Cost:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.AliceBlue;
            this.label6.Location = new System.Drawing.Point(16, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Weight:";
            // 
            // countCombobox
            // 
            this.countCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countCombobox.FormattingEnabled = true;
            this.countCombobox.Location = new System.Drawing.Point(275, 176);
            this.countCombobox.Name = "countCombobox";
            this.countCombobox.Size = new System.Drawing.Size(186, 28);
            this.countCombobox.TabIndex = 42;
            // 
            // countNumericUpDown
            // 
            this.countNumericUpDown.Location = new System.Drawing.Point(169, 177);
            this.countNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.countNumericUpDown.Name = "countNumericUpDown";
            this.countNumericUpDown.ReadOnly = true;
            this.countNumericUpDown.Size = new System.Drawing.Size(80, 26);
            this.countNumericUpDown.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(16, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(16, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Name(EN):";
            // 
            // plNameEN
            // 
            this.plNameEN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plNameEN.Location = new System.Drawing.Point(169, 134);
            this.plNameEN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plNameEN.Name = "plNameEN";
            this.plNameEN.PlaceholderText = "Name (EN)";
            this.plNameEN.ReadOnly = true;
            this.plNameEN.Size = new System.Drawing.Size(292, 26);
            this.plNameEN.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(16, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Name(RU):";
            // 
            // plNameRU
            // 
            this.plNameRU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plNameRU.Location = new System.Drawing.Point(169, 95);
            this.plNameRU.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plNameRU.Name = "plNameRU";
            this.plNameRU.PlaceholderText = "Name (RU)";
            this.plNameRU.ReadOnly = true;
            this.plNameRU.Size = new System.Drawing.Size(292, 26);
            this.plNameRU.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "HSCode:";
            // 
            // plHSCode
            // 
            this.plHSCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plHSCode.Location = new System.Drawing.Point(169, 56);
            this.plHSCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plHSCode.Name = "plHSCode";
            this.plHSCode.PlaceholderText = "HSCode";
            this.plHSCode.ReadOnly = true;
            this.plHSCode.Size = new System.Drawing.Size(292, 26);
            this.plHSCode.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Code:";
            // 
            // plCode
            // 
            this.plCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plCode.Location = new System.Drawing.Point(169, 14);
            this.plCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plCode.Name = "plCode";
            this.plCode.PlaceholderText = "Code";
            this.plCode.ReadOnly = true;
            this.plCode.Size = new System.Drawing.Size(292, 26);
            this.plCode.TabIndex = 32;
            // 
            // customerPanel
            // 
            this.customerPanel.Controls.Add(this.label9);
            this.customerPanel.Controls.Add(this.label10);
            this.customerPanel.Controls.Add(this.label11);
            this.customerPanel.Controls.Add(this.label12);
            this.customerPanel.Controls.Add(this.surnamePL);
            this.customerPanel.Controls.Add(this.namePL);
            this.customerPanel.Controls.Add(this.passwordPL);
            this.customerPanel.Controls.Add(this.loginPL);
            this.customerPanel.Location = new System.Drawing.Point(0, 0);
            this.customerPanel.Name = "customerPanel";
            this.customerPanel.Size = new System.Drawing.Size(450, 170);
            this.customerPanel.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.AliceBlue;
            this.label9.Location = new System.Drawing.Point(18, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Surname:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.AliceBlue;
            this.label10.Location = new System.Drawing.Point(18, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.AliceBlue;
            this.label11.Location = new System.Drawing.Point(18, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Password:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.AliceBlue;
            this.label12.Location = new System.Drawing.Point(18, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Login:";
            // 
            // surnamePL
            // 
            this.surnamePL.Location = new System.Drawing.Point(171, 124);
            this.surnamePL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.surnamePL.Name = "surnamePL";
            this.surnamePL.PlaceholderText = "Surname";
            this.surnamePL.ReadOnly = true;
            this.surnamePL.Size = new System.Drawing.Size(260, 26);
            this.surnamePL.TabIndex = 15;
            // 
            // namePL
            // 
            this.namePL.Location = new System.Drawing.Point(171, 88);
            this.namePL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.namePL.Name = "namePL";
            this.namePL.PlaceholderText = "Name";
            this.namePL.ReadOnly = true;
            this.namePL.Size = new System.Drawing.Size(260, 26);
            this.namePL.TabIndex = 14;
            // 
            // passwordPL
            // 
            this.passwordPL.Location = new System.Drawing.Point(171, 52);
            this.passwordPL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordPL.Name = "passwordPL";
            this.passwordPL.PlaceholderText = "Password";
            this.passwordPL.ReadOnly = true;
            this.passwordPL.Size = new System.Drawing.Size(260, 26);
            this.passwordPL.TabIndex = 13;
            // 
            // loginPL
            // 
            this.loginPL.Location = new System.Drawing.Point(171, 16);
            this.loginPL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginPL.Name = "loginPL";
            this.loginPL.PlaceholderText = "Login";
            this.loginPL.ReadOnly = true;
            this.loginPL.Size = new System.Drawing.Size(260, 26);
            this.loginPL.TabIndex = 12;
            // 
            // locationPanel
            // 
            this.locationPanel.Controls.Add(this.splitContainer1);
            this.locationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationPanel.Location = new System.Drawing.Point(0, 0);
            this.locationPanel.Name = "locationPanel";
            this.locationPanel.Size = new System.Drawing.Size(750, 477);
            this.locationPanel.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label17);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.addressPL);
            this.splitContainer1.Panel1.Controls.Add(this.label16);
            this.splitContainer1.Panel1.Controls.Add(this.label15);
            this.splitContainer1.Panel1.Controls.Add(this.longitudePL);
            this.splitContainer1.Panel1.Controls.Add(this.latitudePL);
            this.splitContainer1.Panel1.Controls.Add(this.label14);
            this.splitContainer1.Panel1.Controls.Add(this.label13);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.vScrollBar1);
            this.splitContainer1.Panel2.Controls.Add(this.gMapControl1);
            this.splitContainer1.Size = new System.Drawing.Size(750, 477);
            this.splitContainer1.SplitterDistance = 326;
            this.splitContainer1.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.Aqua;
            this.label17.Location = new System.Drawing.Point(207, 88);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 16);
            this.label17.TabIndex = 4;
            this.label17.Text = "Reload address";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(22, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "&OK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(210, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "&Cancel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // addressPL
            // 
            this.addressPL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressPL.Location = new System.Drawing.Point(120, 138);
            this.addressPL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addressPL.Multiline = true;
            this.addressPL.Name = "addressPL";
            this.addressPL.PlaceholderText = "Address";
            this.addressPL.Size = new System.Drawing.Size(191, 261);
            this.addressPL.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.AliceBlue;
            this.label16.Location = new System.Drawing.Point(18, 141);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 20);
            this.label16.TabIndex = 25;
            this.label16.Text = "Address:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.Aqua;
            this.label15.Location = new System.Drawing.Point(19, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 16);
            this.label15.TabIndex = 3;
            this.label15.Text = "Reload map";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // longitudePL
            // 
            this.longitudePL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.longitudePL.Location = new System.Drawing.Point(120, 52);
            this.longitudePL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.longitudePL.Name = "longitudePL";
            this.longitudePL.PlaceholderText = "Longitude";
            this.longitudePL.Size = new System.Drawing.Size(191, 26);
            this.longitudePL.TabIndex = 2;
            // 
            // latitudePL
            // 
            this.latitudePL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.latitudePL.Location = new System.Drawing.Point(120, 17);
            this.latitudePL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.latitudePL.Name = "latitudePL";
            this.latitudePL.PlaceholderText = "Latitude";
            this.latitudePL.Size = new System.Drawing.Size(191, 26);
            this.latitudePL.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.AliceBlue;
            this.label14.Location = new System.Drawing.Point(18, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 20);
            this.label14.TabIndex = 21;
            this.label14.Text = "Longitude:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.AliceBlue;
            this.label13.Location = new System.Drawing.Point(18, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Latitude:";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(403, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 477);
            this.vScrollBar1.TabIndex = 8;
            this.vScrollBar1.ValueChanged += new System.EventHandler(this.vScrollBar1_ValueChanged);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 0);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(420, 477);
            this.gMapControl1.TabIndex = 9;
            this.gMapControl1.Zoom = 0D;
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(750, 477);
            this.Controls.Add(this.locationPanel);
            this.Controls.Add(this.productPanel);
            this.Controls.Add(this.customerPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DetailForm_Load);
            this.productPanel.ResumeLayout(false);
            this.productPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costNumericUpdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).EndInit();
            this.customerPanel.ResumeLayout(false);
            this.customerPanel.PerformLayout();
            this.locationPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel productPanel;
        private System.Windows.Forms.NumericUpDown weightNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PlaceholderTextBox plModel;
        private System.Windows.Forms.ComboBox costCombobox;
        private System.Windows.Forms.NumericUpDown costNumericUpdown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox countCombobox;
        private System.Windows.Forms.NumericUpDown countNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PlaceholderTextBox plNameEN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PlaceholderTextBox plNameRU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PlaceholderTextBox plHSCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PlaceholderTextBox plCode;
        private System.Windows.Forms.Panel customerPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PlaceholderTextBox surnamePL;
        private System.Windows.Forms.PlaceholderTextBox namePL;
        private System.Windows.Forms.PlaceholderTextBox passwordPL;
        private System.Windows.Forms.PlaceholderTextBox loginPL;
        private System.Windows.Forms.Panel locationPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PlaceholderTextBox addressPL;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PlaceholderTextBox longitudePL;
        private System.Windows.Forms.PlaceholderTextBox latitudePL;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}