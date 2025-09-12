namespace RestaurantManagement
{
    partial class CashierForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoutCashier = new System.Windows.Forms.Button();
            this.customerCashier = new System.Windows.Forms.Button();
            this.orderCashier = new System.Windows.Forms.Button();
            this.addProductsCashier = new System.Windows.Forms.Button();
            this.dashboardCashier = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.dashboard1 = new RestaurantManagement.Dashboard();
            this.addProduct1 = new RestaurantManagement.AddProduct();
            this.orderForm1 = new RestaurantManagement.OrderForm();
            this.customers1 = new RestaurantManagement.Customers();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "Restaurant Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.panel2.Controls.Add(this.logoutCashier);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.customerCashier);
            this.panel2.Controls.Add(this.orderCashier);
            this.panel2.Controls.Add(this.addProductsCashier);
            this.panel2.Controls.Add(this.dashboardCashier);
            this.panel2.Controls.Add(this.username);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 859);
            this.panel2.TabIndex = 31;
            // 
            // logoutCashier
            // 
            this.logoutCashier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.logoutCashier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoutCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutCashier.ForeColor = System.Drawing.Color.White;
            this.logoutCashier.Location = new System.Drawing.Point(12, 760);
            this.logoutCashier.Name = "logoutCashier";
            this.logoutCashier.Size = new System.Drawing.Size(237, 39);
            this.logoutCashier.TabIndex = 20;
            this.logoutCashier.Text = "Logout";
            this.logoutCashier.UseVisualStyleBackColor = false;
            // 
            // customerCashier
            // 
            this.customerCashier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.customerCashier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.customerCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerCashier.ForeColor = System.Drawing.Color.White;
            this.customerCashier.Location = new System.Drawing.Point(12, 597);
            this.customerCashier.Name = "customerCashier";
            this.customerCashier.Size = new System.Drawing.Size(237, 39);
            this.customerCashier.TabIndex = 19;
            this.customerCashier.Text = "Klientet";
            this.customerCashier.UseVisualStyleBackColor = false;
            // 
            // orderCashier
            // 
            this.orderCashier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.orderCashier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.orderCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderCashier.ForeColor = System.Drawing.Color.White;
            this.orderCashier.Location = new System.Drawing.Point(12, 533);
            this.orderCashier.Name = "orderCashier";
            this.orderCashier.Size = new System.Drawing.Size(237, 39);
            this.orderCashier.TabIndex = 18;
            this.orderCashier.Text = "Porosit";
            this.orderCashier.UseVisualStyleBackColor = false;
            // 
            // addProductsCashier
            // 
            this.addProductsCashier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.addProductsCashier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addProductsCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductsCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductsCashier.ForeColor = System.Drawing.Color.White;
            this.addProductsCashier.Location = new System.Drawing.Point(12, 471);
            this.addProductsCashier.Name = "addProductsCashier";
            this.addProductsCashier.Size = new System.Drawing.Size(237, 39);
            this.addProductsCashier.TabIndex = 17;
            this.addProductsCashier.Text = "Shto Produkte";
            this.addProductsCashier.UseVisualStyleBackColor = false;
            // 
            // dashboardCashier
            // 
            this.dashboardCashier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.dashboardCashier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dashboardCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardCashier.ForeColor = System.Drawing.Color.White;
            this.dashboardCashier.Location = new System.Drawing.Point(12, 410);
            this.dashboardCashier.Name = "dashboardCashier";
            this.dashboardCashier.Size = new System.Drawing.Size(237, 39);
            this.dashboardCashier.TabIndex = 16;
            this.dashboardCashier.Text = "Dashboard";
            this.dashboardCashier.UseVisualStyleBackColor = false;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(143, 328);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(63, 22);
            this.username.TabIndex = 15;
            this.username.Text = "Cashier";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(53, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Username:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(53, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 27);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cashier\'s Portal";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RestaurantManagement.Properties.Resources.icons8_person_901;
            this.pictureBox2.Location = new System.Drawing.Point(58, 147);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addProduct1);
            this.panel1.Controls.Add(this.dashboard1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(261, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 859);
            this.panel1.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.customers1);
            this.panel3.Controls.Add(this.orderForm1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1190, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "x";
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1224, 859);
            this.dashboard1.TabIndex = 5;
            // 
            // addProduct1
            // 
            this.addProduct1.Location = new System.Drawing.Point(0, 0);
            this.addProduct1.Name = "addProduct1";
            this.addProduct1.Size = new System.Drawing.Size(1224, 859);
            this.addProduct1.TabIndex = 6;
            // 
            // orderForm1
            // 
            this.orderForm1.Location = new System.Drawing.Point(0, 0);
            this.orderForm1.Name = "orderForm1";
            this.orderForm1.Size = new System.Drawing.Size(1224, 859);
            this.orderForm1.TabIndex = 7;
            // 
            // customers1
            // 
            this.customers1.Location = new System.Drawing.Point(0, 0);
            this.customers1.Name = "customers1";
            this.customers1.Size = new System.Drawing.Size(1224, 856);
            this.customers1.TabIndex = 7;
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 859);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\\";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button logoutCashier;
        private System.Windows.Forms.Button customerCashier;
        private System.Windows.Forms.Button orderCashier;
        private System.Windows.Forms.Button addProductsCashier;
        private System.Windows.Forms.Button dashboardCashier;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Dashboard dashboard1;
        private AddProduct addProduct1;
        private Customers customers1;
        private OrderForm orderForm1;
    }
}