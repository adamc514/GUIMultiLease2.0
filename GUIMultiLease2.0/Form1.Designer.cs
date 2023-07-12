
namespace GUIMultiLease2._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Audit = new System.Windows.Forms.Button();
            this.Lease = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxFirstName1 = new System.Windows.Forms.TextBox();
            this.textBoxLastName1 = new System.Windows.Forms.TextBox();
            this.textBoxAddress1 = new System.Windows.Forms.TextBox();
            this.textBoxCity1 = new System.Windows.Forms.TextBox();
            this.textBoxPostalCode1 = new System.Windows.Forms.TextBox();
            this.comboBoxProvince1 = new System.Windows.Forms.ComboBox();
            this.textBoxPhoneNumber1 = new System.Windows.Forms.TextBox();
            this.textBoxCustID1 = new System.Windows.Forms.TextBox();
            this.textBoxLeaseID1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(758, 187);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 272);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(758, 171);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Audit);
            this.groupBox1.Controls.Add(this.Lease);
            this.groupBox1.Controls.Add(this.View);
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.Controls.Add(this.Update);
            this.groupBox1.Controls.Add(this.Insert);
            this.groupBox1.Location = new System.Drawing.Point(3, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 70);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Return Lease";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Audit
            // 
            this.Audit.Location = new System.Drawing.Point(529, 34);
            this.Audit.Name = "Audit";
            this.Audit.Size = new System.Drawing.Size(75, 23);
            this.Audit.TabIndex = 5;
            this.Audit.Text = "Audit";
            this.Audit.UseVisualStyleBackColor = true;
            this.Audit.Click += new System.EventHandler(this.Audit_Click);
            // 
            // Lease
            // 
            this.Lease.Location = new System.Drawing.Point(427, 34);
            this.Lease.Name = "Lease";
            this.Lease.Size = new System.Drawing.Size(75, 23);
            this.Lease.TabIndex = 4;
            this.Lease.Text = "Lease";
            this.Lease.UseVisualStyleBackColor = true;
            this.Lease.Click += new System.EventHandler(this.Lease_Click);
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(326, 34);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(75, 23);
            this.View.TabIndex = 3;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(223, 34);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(123, 34);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 1;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(20, 34);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 0;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Province";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Postal Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Phone Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Customer ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(476, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Lease ID";
            // 
            // textBoxFirstName1
            // 
            this.textBoxFirstName1.Location = new System.Drawing.Point(96, 28);
            this.textBoxFirstName1.Name = "textBoxFirstName1";
            this.textBoxFirstName1.Size = new System.Drawing.Size(124, 23);
            this.textBoxFirstName1.TabIndex = 12;
            // 
            // textBoxLastName1
            // 
            this.textBoxLastName1.Location = new System.Drawing.Point(96, 88);
            this.textBoxLastName1.Name = "textBoxLastName1";
            this.textBoxLastName1.Size = new System.Drawing.Size(124, 23);
            this.textBoxLastName1.TabIndex = 13;
            // 
            // textBoxAddress1
            // 
            this.textBoxAddress1.Location = new System.Drawing.Point(96, 135);
            this.textBoxAddress1.Name = "textBoxAddress1";
            this.textBoxAddress1.Size = new System.Drawing.Size(124, 23);
            this.textBoxAddress1.TabIndex = 14;
            // 
            // textBoxCity1
            // 
            this.textBoxCity1.Location = new System.Drawing.Point(307, 28);
            this.textBoxCity1.Name = "textBoxCity1";
            this.textBoxCity1.Size = new System.Drawing.Size(136, 23);
            this.textBoxCity1.TabIndex = 15;
            // 
            // textBoxPostalCode1
            // 
            this.textBoxPostalCode1.Location = new System.Drawing.Point(307, 135);
            this.textBoxPostalCode1.Name = "textBoxPostalCode1";
            this.textBoxPostalCode1.Size = new System.Drawing.Size(136, 23);
            this.textBoxPostalCode1.TabIndex = 17;
            // 
            // comboBoxProvince1
            // 
            this.comboBoxProvince1.FormattingEnabled = true;
            this.comboBoxProvince1.Items.AddRange(new object[] {
            "NL",
            "PE",
            "NS",
            "NB",
            "ON",
            "QC",
            "MB",
            "SK",
            "AB",
            "BC",
            "YT",
            "NT",
            "NU"});
            this.comboBoxProvince1.Location = new System.Drawing.Point(307, 86);
            this.comboBoxProvince1.Name = "comboBoxProvince1";
            this.comboBoxProvince1.Size = new System.Drawing.Size(136, 23);
            this.comboBoxProvince1.TabIndex = 18;
            // 
            // textBoxPhoneNumber1
            // 
            this.textBoxPhoneNumber1.Location = new System.Drawing.Point(584, 28);
            this.textBoxPhoneNumber1.Name = "textBoxPhoneNumber1";
            this.textBoxPhoneNumber1.Size = new System.Drawing.Size(136, 23);
            this.textBoxPhoneNumber1.TabIndex = 19;
            // 
            // textBoxCustID1
            // 
            this.textBoxCustID1.Location = new System.Drawing.Point(584, 88);
            this.textBoxCustID1.Name = "textBoxCustID1";
            this.textBoxCustID1.Size = new System.Drawing.Size(136, 23);
            this.textBoxCustID1.TabIndex = 20;
            // 
            // textBoxLeaseID1
            // 
            this.textBoxLeaseID1.Location = new System.Drawing.Point(584, 145);
            this.textBoxLeaseID1.Name = "textBoxLeaseID1";
            this.textBoxLeaseID1.Size = new System.Drawing.Size(136, 23);
            this.textBoxLeaseID1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 443);
            this.Controls.Add(this.textBoxLeaseID1);
            this.Controls.Add(this.textBoxCustID1);
            this.Controls.Add(this.textBoxPhoneNumber1);
            this.Controls.Add(this.comboBoxProvince1);
            this.Controls.Add(this.textBoxPostalCode1);
            this.Controls.Add(this.textBoxCity1);
            this.Controls.Add(this.textBoxAddress1);
            this.Controls.Add(this.textBoxLastName1);
            this.Controls.Add(this.textBoxFirstName1);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button Audit;
        private System.Windows.Forms.Button Lease;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxFirstName1;
        private System.Windows.Forms.TextBox textBoxLastName1;
        private System.Windows.Forms.TextBox textBoxAddress1;
        private System.Windows.Forms.TextBox textBoxCity1;
        private System.Windows.Forms.TextBox textBoxPostalCode1;
        private System.Windows.Forms.ComboBox comboBoxProvince1;
        private System.Windows.Forms.TextBox textBoxPhoneNumber1;
        private System.Windows.Forms.TextBox textBoxCustID1;
        private System.Windows.Forms.TextBox textBoxLeaseID1;
        private System.Windows.Forms.Button button1;
    }
}

