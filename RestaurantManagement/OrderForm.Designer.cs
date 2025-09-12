namespace RestaurantManagement
{
    partial class OrderForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Order_menu = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.orderProductPrice = new System.Windows.Forms.TextBox();
            this.orderProductName = new System.Windows.Forms.TextBox();
            this.orderClearBtn = new System.Windows.Forms.Button();
            this.orderRemoveBtn = new System.Windows.Forms.Button();
            this.orderAddBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orderQuality = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.orderProdId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orderType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.orderChange = new System.Windows.Forms.TextBox();
            this.orderPayPrice = new System.Windows.Forms.TextBox();
            this.orderReceiptBtn = new System.Windows.Forms.Button();
            this.orderPayBtn = new System.Windows.Forms.Button();
            this.PayPrice = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Change = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.orderAmountText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cashierOrder_T = new System.Windows.Forms.Panel();
            this.cashierOrder_Table = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Order_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderQuality)).BeginInit();
            this.panel3.SuspendLayout();
            this.cashierOrder_T.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrder_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Order_menu);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(18, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 577);
            this.panel1.TabIndex = 0;
            // 
            // Order_menu
            // 
            this.Order_menu.AllowUserToAddRows = false;
            this.Order_menu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.Order_menu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Order_menu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Order_menu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Order_menu.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Order_menu.DefaultCellStyle = dataGridViewCellStyle3;
            this.Order_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Order_menu.EnableHeadersVisualStyles = false;
            this.Order_menu.Location = new System.Drawing.Point(0, 0);
            this.Order_menu.Name = "Order_menu";
            this.Order_menu.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Order_menu.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Order_menu.RowHeadersVisible = false;
            this.Order_menu.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.Order_menu.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Order_menu.RowTemplate.Height = 24;
            this.Order_menu.Size = new System.Drawing.Size(791, 577);
            this.Order_menu.TabIndex = 3;
            this.Order_menu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Order_menu_CellClick);
            this.Order_menu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Order_menu_CellContentClick_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(426, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(539, 514);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.orderProductPrice);
            this.panel2.Controls.Add(this.orderProductName);
            this.panel2.Controls.Add(this.orderClearBtn);
            this.panel2.Controls.Add(this.orderRemoveBtn);
            this.panel2.Controls.Add(this.orderAddBtn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.orderQuality);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.orderProdId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.orderType);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(18, 648);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 225);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // orderProductPrice
            // 
            this.orderProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderProductPrice.Location = new System.Drawing.Point(412, 91);
            this.orderProductPrice.Name = "orderProductPrice";
            this.orderProductPrice.ReadOnly = true;
            this.orderProductPrice.Size = new System.Drawing.Size(118, 27);
            this.orderProductPrice.TabIndex = 25;
            // 
            // orderProductName
            // 
            this.orderProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderProductName.Location = new System.Drawing.Point(175, 140);
            this.orderProductName.Name = "orderProductName";
            this.orderProductName.ReadOnly = true;
            this.orderProductName.Size = new System.Drawing.Size(191, 27);
            this.orderProductName.TabIndex = 24;
            // 
            // orderClearBtn
            // 
            this.orderClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.orderClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderClearBtn.ForeColor = System.Drawing.Color.White;
            this.orderClearBtn.Location = new System.Drawing.Point(586, 146);
            this.orderClearBtn.Name = "orderClearBtn";
            this.orderClearBtn.Size = new System.Drawing.Size(193, 53);
            this.orderClearBtn.TabIndex = 23;
            this.orderClearBtn.Text = "Pastro Textin";
            this.orderClearBtn.UseVisualStyleBackColor = false;
            this.orderClearBtn.Click += new System.EventHandler(this.orderClearBtn_Click);
            // 
            // orderRemoveBtn
            // 
            this.orderRemoveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.orderRemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderRemoveBtn.ForeColor = System.Drawing.Color.White;
            this.orderRemoveBtn.Location = new System.Drawing.Point(586, 82);
            this.orderRemoveBtn.Name = "orderRemoveBtn";
            this.orderRemoveBtn.Size = new System.Drawing.Size(193, 53);
            this.orderRemoveBtn.TabIndex = 22;
            this.orderRemoveBtn.Text = "Fshij";
            this.orderRemoveBtn.UseVisualStyleBackColor = false;
            this.orderRemoveBtn.Click += new System.EventHandler(this.orderRemoveBtn_Click);
            // 
            // orderAddBtn
            // 
            this.orderAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.orderAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderAddBtn.ForeColor = System.Drawing.Color.White;
            this.orderAddBtn.Location = new System.Drawing.Point(586, 21);
            this.orderAddBtn.Name = "orderAddBtn";
            this.orderAddBtn.Size = new System.Drawing.Size(193, 53);
            this.orderAddBtn.TabIndex = 21;
            this.orderAddBtn.Text = "Shto";
            this.orderAddBtn.UseVisualStyleBackColor = false;
            this.orderAddBtn.Click += new System.EventHandler(this.orderAddBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(322, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cmimi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Sasia:";
            // 
            // orderQuality
            // 
            this.orderQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderQuality.Location = new System.Drawing.Point(412, 47);
            this.orderQuality.Name = "orderQuality";
            this.orderQuality.Size = new System.Drawing.Size(118, 27);
            this.orderQuality.TabIndex = 16;
            this.orderQuality.ValueChanged += new System.EventHandler(this.orderQuality_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Product Name:";
            // 
            // orderProdId
            // 
            this.orderProdId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderProdId.FormattingEnabled = true;
            this.orderProdId.Location = new System.Drawing.Point(111, 43);
            this.orderProdId.Name = "orderProdId";
            this.orderProdId.Size = new System.Drawing.Size(178, 28);
            this.orderProdId.TabIndex = 13;
            this.orderProdId.SelectedIndexChanged += new System.EventHandler(this.orderProdId_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID:";
            // 
            // orderType
            // 
            this.orderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderType.FormattingEnabled = true;
            this.orderType.Items.AddRange(new object[] {
            "Food\t",
            "Drink\t",
            "Dessert\t",
            "Appetizer\t",
            "Main Course\t",
            "Beverage\t",
            "Combo Meal\t",
            "Special"});
            this.orderType.Location = new System.Drawing.Point(111, 90);
            this.orderType.Name = "orderType";
            this.orderType.Size = new System.Drawing.Size(178, 28);
            this.orderType.TabIndex = 11;
            this.orderType.SelectedIndexChanged += new System.EventHandler(this.orderType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Lloji:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.orderChange);
            this.panel3.Controls.Add(this.orderPayPrice);
            this.panel3.Controls.Add(this.orderReceiptBtn);
            this.panel3.Controls.Add(this.orderPayBtn);
            this.panel3.Controls.Add(this.PayPrice);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.Change);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.orderAmountText);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.cashierOrder_T);
            this.panel3.Location = new System.Drawing.Point(815, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 831);
            this.panel3.TabIndex = 2;
            // 
            // orderChange
            // 
            this.orderChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderChange.Location = new System.Drawing.Point(192, 727);
            this.orderChange.Name = "orderChange";
            this.orderChange.ReadOnly = true;
            this.orderChange.Size = new System.Drawing.Size(170, 27);
            this.orderChange.TabIndex = 27;
            // 
            // orderPayPrice
            // 
            this.orderPayPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderPayPrice.Location = new System.Drawing.Point(189, 645);
            this.orderPayPrice.Name = "orderPayPrice";
            this.orderPayPrice.ReadOnly = true;
            this.orderPayPrice.Size = new System.Drawing.Size(173, 27);
            this.orderPayPrice.TabIndex = 26;
            // 
            // orderReceiptBtn
            // 
            this.orderReceiptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.orderReceiptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderReceiptBtn.ForeColor = System.Drawing.Color.White;
            this.orderReceiptBtn.Location = new System.Drawing.Point(225, 767);
            this.orderReceiptBtn.Name = "orderReceiptBtn";
            this.orderReceiptBtn.Size = new System.Drawing.Size(169, 53);
            this.orderReceiptBtn.TabIndex = 24;
            this.orderReceiptBtn.Text = "Kuponi";
            this.orderReceiptBtn.UseVisualStyleBackColor = false;
            this.orderReceiptBtn.Click += new System.EventHandler(this.orderReceiptBtn_Click);
            // 
            // orderPayBtn
            // 
            this.orderPayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.orderPayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderPayBtn.ForeColor = System.Drawing.Color.White;
            this.orderPayBtn.Location = new System.Drawing.Point(38, 767);
            this.orderPayBtn.Name = "orderPayBtn";
            this.orderPayBtn.Size = new System.Drawing.Size(170, 53);
            this.orderPayBtn.TabIndex = 23;
            this.orderPayBtn.Text = "Paguaj";
            this.orderPayBtn.UseVisualStyleBackColor = false;
            this.orderPayBtn.Click += new System.EventHandler(this.orderPayBtn_Click);
            // 
            // PayPrice
            // 
            this.PayPrice.AutoSize = true;
            this.PayPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayPrice.Location = new System.Drawing.Point(188, 650);
            this.PayPrice.Name = "PayPrice";
            this.PayPrice.Size = new System.Drawing.Size(20, 22);
            this.PayPrice.TabIndex = 22;
            this.PayPrice.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(34, 649);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 22);
            this.label14.TabIndex = 21;
            this.label14.Text = "Cmimi Total:";
            // 
            // Change
            // 
            this.Change.AutoSize = true;
            this.Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change.Location = new System.Drawing.Point(196, 727);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(20, 22);
            this.Change.TabIndex = 17;
            this.Change.Text = "0";
            this.Change.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(34, 732);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 22);
            this.label11.TabIndex = 16;
            this.label11.Text = "Kthimi:";
            // 
            // orderAmountText
            // 
            this.orderAmountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderAmountText.Location = new System.Drawing.Point(189, 684);
            this.orderAmountText.Name = "orderAmountText";
            this.orderAmountText.Size = new System.Drawing.Size(173, 27);
            this.orderAmountText.TabIndex = 15;
            this.orderAmountText.TextChanged += new System.EventHandler(this.orderAmountText_TextChanged);
            this.orderAmountText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.orderAmountText_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 692);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 22);
            this.label10.TabIndex = 14;
            this.label10.Text = "Shuma e Dhene:";
            // 
            // cashierOrder_T
            // 
            this.cashierOrder_T.BackColor = System.Drawing.Color.DarkGray;
            this.cashierOrder_T.Controls.Add(this.cashierOrder_Table);
            this.cashierOrder_T.Location = new System.Drawing.Point(3, 0);
            this.cashierOrder_T.Name = "cashierOrder_T";
            this.cashierOrder_T.Size = new System.Drawing.Size(435, 606);
            this.cashierOrder_T.TabIndex = 0;
            // 
            // cashierOrder_Table
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.cashierOrder_Table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cashierOrder_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.cashierOrder_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cashierOrder_Table.Location = new System.Drawing.Point(2, -11);
            this.cashierOrder_Table.Name = "cashierOrder_Table";
            this.cashierOrder_Table.RowHeadersWidth = 51;
            this.cashierOrder_Table.RowTemplate.Height = 24;
            this.cashierOrder_Table.Size = new System.Drawing.Size(435, 617);
            this.cashierOrder_Table.TabIndex = 1;
            this.cashierOrder_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cashierOrder_Table_CellClick);
            this.cashierOrder_Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cashierOrder_Table_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "Menu";
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "OrderForm";
            this.Size = new System.Drawing.Size(1263, 881);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Order_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderQuality)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.cashierOrder_T.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrder_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView Order_menu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox orderType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox orderProdId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown orderQuality;
        private System.Windows.Forms.Button orderClearBtn;
        private System.Windows.Forms.Button orderRemoveBtn;
        private System.Windows.Forms.Button orderAddBtn;
        private System.Windows.Forms.Panel cashierOrder_T;
        private System.Windows.Forms.TextBox orderAmountText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Change;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label PayPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button orderReceiptBtn;
        private System.Windows.Forms.Button orderPayBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView cashierOrder_Table;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox orderProductPrice;
        private System.Windows.Forms.TextBox orderProductName;
        private System.Windows.Forms.TextBox orderPayPrice;
        private System.Windows.Forms.TextBox orderChange;
    }
}
