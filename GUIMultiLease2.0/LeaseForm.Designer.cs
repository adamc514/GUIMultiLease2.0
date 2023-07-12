
namespace GUIMultiLease2._0
{
    partial class LeaseForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxContractStart1 = new System.Windows.Forms.TextBox();
            this.textBoxFirstPayment1 = new System.Windows.Forms.TextBox();
            this.textBoxAmtPerMonth = new System.Windows.Forms.TextBox();
            this.textBoxVehicleLeased1 = new System.Windows.Forms.TextBox();
            this.TextBoxNumOfMonths = new System.Windows.Forms.TextBox();
            this.textBoxCustomer1 = new System.Windows.Forms.TextBox();
            this.textBoxCustomerID1 = new System.Windows.Forms.TextBox();
            this.textBoxLeasedID1 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBoxVIN1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(827, 169);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(2, 242);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(829, 137);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(2, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functions";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(454, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "View";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(305, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contract Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Payment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Monthly Payments";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Num Monthly Payments";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Vehicle Leased";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Customer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(568, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Customer ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(556, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Vehicle Leased ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(568, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "VIN Number";
            // 
            // textBoxContractStart1
            // 
            this.textBoxContractStart1.Location = new System.Drawing.Point(115, 21);
            this.textBoxContractStart1.Name = "textBoxContractStart1";
            this.textBoxContractStart1.Size = new System.Drawing.Size(124, 23);
            this.textBoxContractStart1.TabIndex = 12;
            // 
            // textBoxFirstPayment1
            // 
            this.textBoxFirstPayment1.Location = new System.Drawing.Point(115, 78);
            this.textBoxFirstPayment1.Name = "textBoxFirstPayment1";
            this.textBoxFirstPayment1.Size = new System.Drawing.Size(124, 23);
            this.textBoxFirstPayment1.TabIndex = 13;
            // 
            // textBoxAmtPerMonth
            // 
            this.textBoxAmtPerMonth.Location = new System.Drawing.Point(125, 131);
            this.textBoxAmtPerMonth.Name = "textBoxAmtPerMonth";
            this.textBoxAmtPerMonth.Size = new System.Drawing.Size(126, 23);
            this.textBoxAmtPerMonth.TabIndex = 14;
            // 
            // textBoxVehicleLeased1
            // 
            this.textBoxVehicleLeased1.Location = new System.Drawing.Point(388, 75);
            this.textBoxVehicleLeased1.Name = "textBoxVehicleLeased1";
            this.textBoxVehicleLeased1.Size = new System.Drawing.Size(143, 23);
            this.textBoxVehicleLeased1.TabIndex = 15;
            // 
            // TextBoxNumOfMonths
            // 
            this.TextBoxNumOfMonths.Location = new System.Drawing.Point(388, 24);
            this.TextBoxNumOfMonths.Name = "TextBoxNumOfMonths";
            this.TextBoxNumOfMonths.Size = new System.Drawing.Size(143, 23);
            this.TextBoxNumOfMonths.TabIndex = 16;
            // 
            // textBoxCustomer1
            // 
            this.textBoxCustomer1.Location = new System.Drawing.Point(388, 136);
            this.textBoxCustomer1.Name = "textBoxCustomer1";
            this.textBoxCustomer1.Size = new System.Drawing.Size(143, 23);
            this.textBoxCustomer1.TabIndex = 17;
            // 
            // textBoxCustomerID1
            // 
            this.textBoxCustomerID1.Location = new System.Drawing.Point(662, 24);
            this.textBoxCustomerID1.Name = "textBoxCustomerID1";
            this.textBoxCustomerID1.Size = new System.Drawing.Size(139, 23);
            this.textBoxCustomerID1.TabIndex = 18;
            // 
            // textBoxLeasedID1
            // 
            this.textBoxLeasedID1.Location = new System.Drawing.Point(662, 75);
            this.textBoxLeasedID1.Name = "textBoxLeasedID1";
            this.textBoxLeasedID1.Size = new System.Drawing.Size(139, 23);
            this.textBoxLeasedID1.TabIndex = 13;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(1218, 16);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(139, 23);
            this.textBox9.TabIndex = 18;
            // 
            // textBoxVIN1
            // 
            this.textBoxVIN1.Location = new System.Drawing.Point(662, 131);
            this.textBoxVIN1.Name = "textBoxVIN1";
            this.textBoxVIN1.Size = new System.Drawing.Size(139, 23);
            this.textBoxVIN1.TabIndex = 19;
            // 
            // LeaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 399);
            this.Controls.Add(this.textBoxVIN1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBoxCustomerID1);
            this.Controls.Add(this.textBoxCustomer1);
            this.Controls.Add(this.TextBoxNumOfMonths);
            this.Controls.Add(this.textBoxVehicleLeased1);
            this.Controls.Add(this.textBoxLeasedID1);
            this.Controls.Add(this.textBoxAmtPerMonth);
            this.Controls.Add(this.textBoxFirstPayment1);
            this.Controls.Add(this.textBoxContractStart1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LeaseForm";
            this.Text = "LeaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxContractStart1;
        private System.Windows.Forms.TextBox textBoxFirstPayment1;
        private System.Windows.Forms.TextBox textBoxAmtPerMonth;
        private System.Windows.Forms.TextBox textBoxVehicleLeased1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextBoxNumOfMonths;
        private System.Windows.Forms.TextBox textBoxCustomer1;
        private System.Windows.Forms.TextBox textBoxCustomerID1;
        private System.Windows.Forms.TextBox textBoxLeasedID1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBoxVIN1;
    }
}