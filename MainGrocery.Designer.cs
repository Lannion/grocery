namespace GroceryStore
{
    partial class MainGrocery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGrocery));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.Close_Button = new System.Windows.Forms.Button();
            this.FreshProduce_button = new System.Windows.Forms.Button();
            this.DairyEggs_button = new System.Windows.Forms.Button();
            this.Bakery_button = new System.Windows.Forms.Button();
            this.Receipt_panel = new System.Windows.Forms.Panel();
            this.receiptdgv = new System.Windows.Forms.DataGridView();
            this.ProductColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Orders_button = new System.Windows.Forms.Button();
            this.inventory_button = new System.Windows.Forms.Button();
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.ClearAll_button = new System.Windows.Forms.Button();
            this.ClearSelected_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmPurchase_button = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.plus_button = new System.Windows.Forms.Button();
            this.Quantity_textbox = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LableName = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.LabelQuantity = new System.Windows.Forms.Label();
            this.addreceipt_button = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalPrice_textbox = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.ItemQuantity_textbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.Receipt_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptdgv)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Close_Button);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(1536, 44);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(632, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(374, 30);
            this.label8.TabIndex = 5;
            this.label8.Text = "Grocery Store Pos System";
            // 
            // Close_Button
            // 
            this.Close_Button.BackColor = System.Drawing.Color.Transparent;
            this.Close_Button.FlatAppearance.BorderSize = 0;
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Button.Font = new System.Drawing.Font("Wingdings 2", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Close_Button.ForeColor = System.Drawing.Color.White;
            this.Close_Button.Location = new System.Drawing.Point(1496, -1);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(45, 45);
            this.Close_Button.TabIndex = 1;
            this.Close_Button.Text = "S";
            this.Close_Button.UseVisualStyleBackColor = false;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // FreshProduce_button
            // 
            this.FreshProduce_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FreshProduce_button.BackgroundImage")));
            this.FreshProduce_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FreshProduce_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FreshProduce_button.FlatAppearance.BorderSize = 2;
            this.FreshProduce_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FreshProduce_button.Location = new System.Drawing.Point(10, 106);
            this.FreshProduce_button.Name = "FreshProduce_button";
            this.FreshProduce_button.Size = new System.Drawing.Size(90, 90);
            this.FreshProduce_button.TabIndex = 1;
            this.FreshProduce_button.UseVisualStyleBackColor = true;
            this.FreshProduce_button.Click += new System.EventHandler(this.FreshProduce_button_Click);
            // 
            // DairyEggs_button
            // 
            this.DairyEggs_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DairyEggs_button.BackgroundImage")));
            this.DairyEggs_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DairyEggs_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DairyEggs_button.FlatAppearance.BorderSize = 2;
            this.DairyEggs_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DairyEggs_button.Location = new System.Drawing.Point(10, 202);
            this.DairyEggs_button.Name = "DairyEggs_button";
            this.DairyEggs_button.Size = new System.Drawing.Size(90, 90);
            this.DairyEggs_button.TabIndex = 2;
            this.DairyEggs_button.UseVisualStyleBackColor = true;
            this.DairyEggs_button.Click += new System.EventHandler(this.DairyEggs_button_Click);
            // 
            // Bakery_button
            // 
            this.Bakery_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bakery_button.BackgroundImage")));
            this.Bakery_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bakery_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Bakery_button.FlatAppearance.BorderSize = 2;
            this.Bakery_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bakery_button.Location = new System.Drawing.Point(10, 298);
            this.Bakery_button.Name = "Bakery_button";
            this.Bakery_button.Size = new System.Drawing.Size(90, 90);
            this.Bakery_button.TabIndex = 3;
            this.Bakery_button.UseVisualStyleBackColor = true;
            this.Bakery_button.Click += new System.EventHandler(this.Bakery_button_Click);
            // 
            // Receipt_panel
            // 
            this.Receipt_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Receipt_panel.Controls.Add(this.receiptdgv);
            this.Receipt_panel.Location = new System.Drawing.Point(61, 104);
            this.Receipt_panel.Name = "Receipt_panel";
            this.Receipt_panel.Size = new System.Drawing.Size(400, 658);
            this.Receipt_panel.TabIndex = 4;
            // 
            // receiptdgv
            // 
            this.receiptdgv.AllowUserToAddRows = false;
            this.receiptdgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.receiptdgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.receiptdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.receiptdgv.ColumnHeadersHeight = 40;
            this.receiptdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductColumn,
            this.PriceColumn,
            this.QuantityColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.receiptdgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.receiptdgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receiptdgv.Location = new System.Drawing.Point(0, 0);
            this.receiptdgv.Name = "receiptdgv";
            this.receiptdgv.ReadOnly = true;
            this.receiptdgv.RowHeadersWidth = 51;
            this.receiptdgv.RowTemplate.Height = 24;
            this.receiptdgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receiptdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.receiptdgv.Size = new System.Drawing.Size(400, 658);
            this.receiptdgv.TabIndex = 27;
            // 
            // ProductColumn
            // 
            this.ProductColumn.HeaderText = "Product";
            this.ProductColumn.MinimumWidth = 6;
            this.ProductColumn.Name = "ProductColumn";
            this.ProductColumn.ReadOnly = true;
            this.ProductColumn.Width = 125;
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.MinimumWidth = 6;
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            this.PriceColumn.Width = 125;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.HeaderText = "Quantity";
            this.QuantityColumn.MinimumWidth = 6;
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.ReadOnly = true;
            this.QuantityColumn.Width = 125;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Aquamarine;
            this.panel3.Controls.Add(this.Orders_button);
            this.panel3.Controls.Add(this.inventory_button);
            this.panel3.Controls.Add(this.FreshProduce_button);
            this.panel3.Controls.Add(this.Bakery_button);
            this.panel3.Controls.Add(this.DairyEggs_button);
            this.panel3.Location = new System.Drawing.Point(521, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 822);
            this.panel3.TabIndex = 10;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Orders_button
            // 
            this.Orders_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Orders_button.BackgroundImage")));
            this.Orders_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Orders_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Orders_button.FlatAppearance.BorderSize = 2;
            this.Orders_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Orders_button.Location = new System.Drawing.Point(10, 538);
            this.Orders_button.Name = "Orders_button";
            this.Orders_button.Size = new System.Drawing.Size(90, 90);
            this.Orders_button.TabIndex = 6;
            this.Orders_button.UseVisualStyleBackColor = true;
            this.Orders_button.Click += new System.EventHandler(this.Orders_button_Click);
            // 
            // inventory_button
            // 
            this.inventory_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inventory_button.BackgroundImage")));
            this.inventory_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inventory_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.inventory_button.FlatAppearance.BorderSize = 2;
            this.inventory_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventory_button.Location = new System.Drawing.Point(10, 442);
            this.inventory_button.Name = "inventory_button";
            this.inventory_button.Size = new System.Drawing.Size(90, 90);
            this.inventory_button.TabIndex = 4;
            this.inventory_button.UseVisualStyleBackColor = true;
            this.inventory_button.Click += new System.EventHandler(this.inventory_button_Click);
            // 
            // Main_Panel
            // 
            this.Main_Panel.BackColor = System.Drawing.SystemColors.Info;
            this.Main_Panel.Location = new System.Drawing.Point(630, 43);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Main_Panel.Size = new System.Drawing.Size(906, 671);
            this.Main_Panel.TabIndex = 11;
            this.Main_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Panel_Paint);
            // 
            // ClearAll_button
            // 
            this.ClearAll_button.BackColor = System.Drawing.Color.Red;
            this.ClearAll_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClearAll_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ClearAll_button.FlatAppearance.BorderSize = 2;
            this.ClearAll_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearAll_button.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAll_button.Location = new System.Drawing.Point(1295, 714);
            this.ClearAll_button.Name = "ClearAll_button";
            this.ClearAll_button.Size = new System.Drawing.Size(241, 50);
            this.ClearAll_button.TabIndex = 13;
            this.ClearAll_button.Text = "Clear All Items";
            this.ClearAll_button.UseVisualStyleBackColor = false;
            this.ClearAll_button.Click += new System.EventHandler(this.ClearAll_button_Click);
            // 
            // ClearSelected_button
            // 
            this.ClearSelected_button.BackColor = System.Drawing.Color.LightCoral;
            this.ClearSelected_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClearSelected_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ClearSelected_button.FlatAppearance.BorderSize = 2;
            this.ClearSelected_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearSelected_button.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearSelected_button.Location = new System.Drawing.Point(1295, 764);
            this.ClearSelected_button.Name = "ClearSelected_button";
            this.ClearSelected_button.Size = new System.Drawing.Size(241, 50);
            this.ClearSelected_button.TabIndex = 14;
            this.ClearSelected_button.Text = "Clear Selected Item";
            this.ClearSelected_button.UseVisualStyleBackColor = false;
            this.ClearSelected_button.Click += new System.EventHandler(this.ClearSelected_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(630, 714);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(222, 50);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Product Name";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(1073, 714);
            this.panel4.Name = "panel4";
            this.panel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel4.Size = new System.Drawing.Size(222, 50);
            this.panel4.TabIndex = 17;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantity";
            // 
            // confirmPurchase_button
            // 
            this.confirmPurchase_button.BackColor = System.Drawing.Color.RoyalBlue;
            this.confirmPurchase_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.confirmPurchase_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.confirmPurchase_button.FlatAppearance.BorderSize = 2;
            this.confirmPurchase_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmPurchase_button.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPurchase_button.Location = new System.Drawing.Point(1295, 814);
            this.confirmPurchase_button.Name = "confirmPurchase_button";
            this.confirmPurchase_button.Size = new System.Drawing.Size(241, 50);
            this.confirmPurchase_button.TabIndex = 18;
            this.confirmPurchase_button.Text = "Confirm Purchases";
            this.confirmPurchase_button.UseVisualStyleBackColor = false;
            this.confirmPurchase_button.Click += new System.EventHandler(this.confirmPurchase_button_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(630, 764);
            this.panel5.Name = "panel5";
            this.panel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel5.Size = new System.Drawing.Size(222, 50);
            this.panel5.TabIndex = 19;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Price";
            // 
            // plus_button
            // 
            this.plus_button.BackColor = System.Drawing.Color.MediumTurquoise;
            this.plus_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.plus_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.plus_button.FlatAppearance.BorderSize = 2;
            this.plus_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus_button.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus_button.Location = new System.Drawing.Point(1184, 814);
            this.plus_button.Name = "plus_button";
            this.plus_button.Size = new System.Drawing.Size(111, 50);
            this.plus_button.TabIndex = 21;
            this.plus_button.Text = "+";
            this.plus_button.UseVisualStyleBackColor = false;
            this.plus_button.Click += new System.EventHandler(this.plus_button_Click);
            // 
            // Quantity_textbox
            // 
            this.Quantity_textbox.BackColor = System.Drawing.Color.Chocolate;
            this.Quantity_textbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Quantity_textbox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Quantity_textbox.FlatAppearance.BorderSize = 2;
            this.Quantity_textbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quantity_textbox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity_textbox.Location = new System.Drawing.Point(1073, 814);
            this.Quantity_textbox.Name = "Quantity_textbox";
            this.Quantity_textbox.Size = new System.Drawing.Size(111, 50);
            this.Quantity_textbox.TabIndex = 22;
            this.Quantity_textbox.Text = "-";
            this.Quantity_textbox.UseVisualStyleBackColor = false;
            this.Quantity_textbox.Click += new System.EventHandler(this.minus_button_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.LableName);
            this.panel6.Location = new System.Drawing.Point(851, 714);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(222, 50);
            this.panel6.TabIndex = 23;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // LableName
            // 
            this.LableName.AutoSize = true;
            this.LableName.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableName.Location = new System.Drawing.Point(16, 10);
            this.LableName.Name = "LableName";
            this.LableName.Size = new System.Drawing.Size(71, 29);
            this.LableName.TabIndex = 7;
            this.LableName.Text = "- - - -";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.LabelPrice);
            this.panel7.Location = new System.Drawing.Point(851, 764);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(222, 50);
            this.panel7.TabIndex = 24;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrice.Location = new System.Drawing.Point(16, 10);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(71, 29);
            this.LabelPrice.TabIndex = 8;
            this.LabelPrice.Text = "- - - -";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Control;
            this.panel8.Controls.Add(this.LabelQuantity);
            this.panel8.Location = new System.Drawing.Point(1073, 764);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(222, 50);
            this.panel8.TabIndex = 25;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // LabelQuantity
            // 
            this.LabelQuantity.AutoSize = true;
            this.LabelQuantity.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQuantity.Location = new System.Drawing.Point(16, 10);
            this.LabelQuantity.Name = "LabelQuantity";
            this.LabelQuantity.Size = new System.Drawing.Size(71, 29);
            this.LabelQuantity.TabIndex = 9;
            this.LabelQuantity.Text = "- - - -";
            // 
            // addreceipt_button
            // 
            this.addreceipt_button.BackColor = System.Drawing.Color.Chartreuse;
            this.addreceipt_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addreceipt_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addreceipt_button.FlatAppearance.BorderSize = 2;
            this.addreceipt_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addreceipt_button.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addreceipt_button.Location = new System.Drawing.Point(851, 814);
            this.addreceipt_button.Name = "addreceipt_button";
            this.addreceipt_button.Size = new System.Drawing.Size(223, 50);
            this.addreceipt_button.TabIndex = 26;
            this.addreceipt_button.Text = "Add Item to receipt";
            this.addreceipt_button.UseVisualStyleBackColor = false;
            this.addreceipt_button.Click += new System.EventHandler(this.addreceipt_button_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel9.Controls.Add(this.label4);
            this.panel9.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.Location = new System.Drawing.Point(61, 762);
            this.panel9.Name = "panel9";
            this.panel9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel9.Size = new System.Drawing.Size(100, 36);
            this.panel9.TabIndex = 20;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Price";
            // 
            // TotalPrice_textbox
            // 
            this.TotalPrice_textbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPrice_textbox.Location = new System.Drawing.Point(162, 763);
            this.TotalPrice_textbox.Name = "TotalPrice_textbox";
            this.TotalPrice_textbox.Size = new System.Drawing.Size(100, 42);
            this.TotalPrice_textbox.TabIndex = 28;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel10.Controls.Add(this.label5);
            this.panel10.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.Location = new System.Drawing.Point(261, 762);
            this.panel10.Name = "panel10";
            this.panel10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel10.Size = new System.Drawing.Size(100, 36);
            this.panel10.TabIndex = 21;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quantity";
            // 
            // ItemQuantity_textbox
            // 
            this.ItemQuantity_textbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQuantity_textbox.Location = new System.Drawing.Point(361, 763);
            this.ItemQuantity_textbox.Name = "ItemQuantity_textbox";
            this.ItemQuantity_textbox.Size = new System.Drawing.Size(100, 42);
            this.ItemQuantity_textbox.TabIndex = 29;
            // 
            // MainGrocery
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1536, 864);
            this.Controls.Add(this.ItemQuantity_textbox);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.addreceipt_button);
            this.Controls.Add(this.TotalPrice_textbox);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.Quantity_textbox);
            this.Controls.Add(this.plus_button);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.confirmPurchase_button);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ClearSelected_button);
            this.Controls.Add(this.ClearAll_button);
            this.Controls.Add(this.Main_Panel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Receipt_panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainGrocery";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainGrocery_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Receipt_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.receiptdgv)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FreshProduce_button;
        private System.Windows.Forms.Button DairyEggs_button;
        private System.Windows.Forms.Button Bakery_button;
        private System.Windows.Forms.Panel Receipt_panel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button inventory_button;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Panel Main_Panel;
        private System.Windows.Forms.Button Orders_button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ClearAll_button;
        private System.Windows.Forms.Button ClearSelected_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confirmPurchase_button;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button plus_button;
        private System.Windows.Forms.Button Quantity_textbox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label LableName;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LabelQuantity;
        private System.Windows.Forms.Button addreceipt_button;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TotalPrice_textbox;
        private System.Windows.Forms.TextBox ItemQuantity_textbox;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView receiptdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
    }
}