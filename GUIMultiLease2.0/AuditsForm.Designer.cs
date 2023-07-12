
namespace GUIMultiLease2._0
{
    partial class AuditsForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNewDate1 = new System.Windows.Forms.TextBox();
            this.textBoxChangedValue = new System.Windows.Forms.TextBox();
            this.textBoxOldValue1 = new System.Windows.Forms.TextBox();
            this.textBoxNewValue1 = new System.Windows.Forms.TextBox();
            this.TextBoxLeasedID1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(634, 167);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(2, 266);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(634, 171);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(2, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 61);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functions";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Changed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Old Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "New Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Leased ID";
            // 
            // textBoxNewDate1
            // 
            this.textBoxNewDate1.Location = new System.Drawing.Point(83, 23);
            this.textBoxNewDate1.Name = "textBoxNewDate1";
            this.textBoxNewDate1.Size = new System.Drawing.Size(162, 23);
            this.textBoxNewDate1.TabIndex = 8;
            // 
            // textBoxChangedValue
            // 
            this.textBoxChangedValue.Location = new System.Drawing.Point(83, 77);
            this.textBoxChangedValue.Name = "textBoxChangedValue";
            this.textBoxChangedValue.Size = new System.Drawing.Size(162, 23);
            this.textBoxChangedValue.TabIndex = 9;
            // 
            // textBoxOldValue1
            // 
            this.textBoxOldValue1.Location = new System.Drawing.Point(83, 132);
            this.textBoxOldValue1.Name = "textBoxOldValue1";
            this.textBoxOldValue1.Size = new System.Drawing.Size(162, 23);
            this.textBoxOldValue1.TabIndex = 10;
            // 
            // textBoxNewValue1
            // 
            this.textBoxNewValue1.Location = new System.Drawing.Point(357, 26);
            this.textBoxNewValue1.Name = "textBoxNewValue1";
            this.textBoxNewValue1.Size = new System.Drawing.Size(163, 23);
            this.textBoxNewValue1.TabIndex = 11;
            // 
            // TextBoxLeasedID1
            // 
            this.TextBoxLeasedID1.Location = new System.Drawing.Point(357, 68);
            this.TextBoxLeasedID1.Name = "TextBoxLeasedID1";
            this.TextBoxLeasedID1.Size = new System.Drawing.Size(163, 23);
            this.TextBoxLeasedID1.TabIndex = 12;
            // 
            // AuditsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 506);
            this.Controls.Add(this.TextBoxLeasedID1);
            this.Controls.Add(this.textBoxNewValue1);
            this.Controls.Add(this.textBoxOldValue1);
            this.Controls.Add(this.textBoxChangedValue);
            this.Controls.Add(this.textBoxNewDate1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AuditsForm";
            this.Text = "AuditsForm";
            this.Load += new System.EventHandler(this.AuditsForm_Load);
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
        private System.Windows.Forms.TextBox textBoxNewDate1;
        private System.Windows.Forms.TextBox textBoxChangedValue;
        private System.Windows.Forms.TextBox textBoxOldValue1;
        private System.Windows.Forms.TextBox textBoxNewValue1;
        private System.Windows.Forms.TextBox TextBoxLeasedID1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}