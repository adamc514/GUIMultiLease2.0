using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUIMultiLease2._0
{
    public partial class AuditsForm : Form
    {
        public AuditsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-IJF0QMQ\\MSSQLSERVER2;Initial Catalog=AD_MultiLeaseDB;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("spViewAudits", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable tbl  = new DataTable())
                        {
                            sda.Fill(tbl);
                            dataGridView2.DataSource = tbl;
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-IJF0QMQ\\MSSQLSERVER2;Initial Catalog=AD_MultiLeaseDB;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("spDeleteAuditInfo", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("LeaseID", SqlDbType.Int).Value = TextBoxLeasedID1.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Audit information has been deleted");
                }
            }
            /*
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-IJF0QMQ\\MSSQLSERVER2;Initial Catalog=AD_MultiLeaseDB;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("spUpdateAudits", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@NewDate", SqlDbType.Date).Value = textBoxNewDate1.Text;
                    cmd.Parameters.Add("Changed", SqlDbType.Bit).Value = textBoxChangedValue.Text;
                    cmd.Parameters.Add("OldValue", SqlDbType.Date).Value = textBoxOldValue1.Text;
                    cmd.Parameters.Add("NewValue", SqlDbType.Date).Value = textBoxNewValue1.Text;
                    cmd.Parameters.Add("LeaseID", SqlDbType.Int).Value = TextBoxLeasedID1.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Audit information has been updated successfully");
                }
            }
            */
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxNewDate1.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            textBoxChangedValue.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            textBoxOldValue1.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            textBoxNewValue1.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            TextBoxLeasedID1.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void AuditsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
