namespace RestaurantManagement
{
    partial class AddUsers
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
            System.Windows.Forms.Button adminAddUsers_importbtn;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adminAddUsers_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adminAddUsers_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adminAddUsers_role = new System.Windows.Forms.ComboBox();
            this.adminAddUsers_status = new System.Windows.Forms.ComboBox();
            this.adminAddUsers_addBtn = new System.Windows.Forms.Button();
            this.adminAddUsers_updateBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.adminAddUsers_clearBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.adminAddusers_image = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            adminAddUsers_importbtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminAddusers_image)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminAddUsers_importbtn
            // 
            adminAddUsers_importbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            adminAddUsers_importbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adminAddUsers_importbtn.ForeColor = System.Drawing.Color.White;
            adminAddUsers_importbtn.Location = new System.Drawing.Point(114, 187);
            adminAddUsers_importbtn.Name = "adminAddUsers_importbtn";
            adminAddUsers_importbtn.Size = new System.Drawing.Size(123, 43);
            adminAddUsers_importbtn.TabIndex = 15;
            adminAddUsers_importbtn.Text = "Import";
            adminAddUsers_importbtn.UseVisualStyleBackColor = false;
            adminAddUsers_importbtn.Click += new System.EventHandler(this.adminAddUsers_importbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(411, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 673);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeight = 29;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(837, 673);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data of Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Emri:";
            // 
            // adminAddUsers_username
            // 
            this.adminAddUsers_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddUsers_username.Location = new System.Drawing.Point(124, 265);
            this.adminAddUsers_username.Name = "adminAddUsers_username";
            this.adminAddUsers_username.Size = new System.Drawing.Size(223, 28);
            this.adminAddUsers_username.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // adminAddUsers_password
            // 
            this.adminAddUsers_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddUsers_password.Location = new System.Drawing.Point(124, 314);
            this.adminAddUsers_password.Name = "adminAddUsers_password";
            this.adminAddUsers_password.Size = new System.Drawing.Size(223, 28);
            this.adminAddUsers_password.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Roli:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Status:";
            // 
            // adminAddUsers_role
            // 
            this.adminAddUsers_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddUsers_role.FormattingEnabled = true;
            this.adminAddUsers_role.Items.AddRange(new object[] {
            "Head Chef",
            "Sous chef",
            "Line Cooks",
            "Prep Cooks",
            "Dishwasher",
            "Head Waiter",
            "Waiter",
            "Host",
            "Manager",
            "Stock Manager",
            "Assistant Manager",
            "Accountant",
            "Cleaner"});
            this.adminAddUsers_role.Location = new System.Drawing.Point(124, 367);
            this.adminAddUsers_role.Name = "adminAddUsers_role";
            this.adminAddUsers_role.Size = new System.Drawing.Size(223, 28);
            this.adminAddUsers_role.TabIndex = 8;
            // 
            // adminAddUsers_status
            // 
            this.adminAddUsers_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddUsers_status.FormattingEnabled = true;
            this.adminAddUsers_status.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Approval"});
            this.adminAddUsers_status.Location = new System.Drawing.Point(124, 412);
            this.adminAddUsers_status.Name = "adminAddUsers_status";
            this.adminAddUsers_status.Size = new System.Drawing.Size(223, 28);
            this.adminAddUsers_status.TabIndex = 9;
            // 
            // adminAddUsers_addBtn
            // 
            this.adminAddUsers_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.adminAddUsers_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddUsers_addBtn.ForeColor = System.Drawing.Color.White;
            this.adminAddUsers_addBtn.Location = new System.Drawing.Point(27, 485);
            this.adminAddUsers_addBtn.Name = "adminAddUsers_addBtn";
            this.adminAddUsers_addBtn.Size = new System.Drawing.Size(152, 53);
            this.adminAddUsers_addBtn.TabIndex = 10;
            this.adminAddUsers_addBtn.Text = "Shto";
            this.adminAddUsers_addBtn.UseVisualStyleBackColor = false;
            this.adminAddUsers_addBtn.Click += new System.EventHandler(this.adminAddUsers_addBtn_Click);
            // 
            // adminAddUsers_updateBtn
            // 
            this.adminAddUsers_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.adminAddUsers_updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddUsers_updateBtn.ForeColor = System.Drawing.Color.White;
            this.adminAddUsers_updateBtn.Location = new System.Drawing.Point(195, 485);
            this.adminAddUsers_updateBtn.Name = "adminAddUsers_updateBtn";
            this.adminAddUsers_updateBtn.Size = new System.Drawing.Size(152, 53);
            this.adminAddUsers_updateBtn.TabIndex = 11;
            this.adminAddUsers_updateBtn.Text = "Perditeso";
            this.adminAddUsers_updateBtn.UseVisualStyleBackColor = false;
            this.adminAddUsers_updateBtn.Click += new System.EventHandler(this.adminAddUsers_updateBtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(27, 546);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 53);
            this.button3.TabIndex = 12;
            this.button3.Text = "Fshi";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // adminAddUsers_clearBtn
            // 
            this.adminAddUsers_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.adminAddUsers_clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddUsers_clearBtn.ForeColor = System.Drawing.Color.White;
            this.adminAddUsers_clearBtn.Location = new System.Drawing.Point(195, 546);
            this.adminAddUsers_clearBtn.Name = "adminAddUsers_clearBtn";
            this.adminAddUsers_clearBtn.Size = new System.Drawing.Size(152, 53);
            this.adminAddUsers_clearBtn.TabIndex = 13;
            this.adminAddUsers_clearBtn.Text = "Pastro textin";
            this.adminAddUsers_clearBtn.UseVisualStyleBackColor = false;
            this.adminAddUsers_clearBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.adminAddusers_image);
            this.panel3.Location = new System.Drawing.Point(114, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(123, 128);
            this.panel3.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(53, 125);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // adminAddusers_image
            // 
            this.adminAddusers_image.Location = new System.Drawing.Point(0, 0);
            this.adminAddusers_image.Name = "adminAddusers_image";
            this.adminAddusers_image.Size = new System.Drawing.Size(123, 128);
            this.adminAddusers_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adminAddusers_image.TabIndex = 0;
            this.adminAddusers_image.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(adminAddUsers_importbtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.adminAddUsers_clearBtn);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.adminAddUsers_updateBtn);
            this.panel1.Controls.Add(this.adminAddUsers_addBtn);
            this.panel1.Controls.Add(this.adminAddUsers_status);
            this.panel1.Controls.Add(this.adminAddUsers_role);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.adminAddUsers_password);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.adminAddUsers_username);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 719);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Te dhenat e Punetoreve";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // AddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddUsers";
            this.Size = new System.Drawing.Size(1251, 745);
            this.Load += new System.EventHandler(this.AddUsers_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminAddusers_image)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adminAddUsers_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adminAddUsers_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox adminAddUsers_role;
        private System.Windows.Forms.ComboBox adminAddUsers_status;
        private System.Windows.Forms.Button adminAddUsers_addBtn;
        private System.Windows.Forms.Button adminAddUsers_updateBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button adminAddUsers_clearBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox adminAddusers_image;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}
