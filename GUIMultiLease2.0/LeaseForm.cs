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
    public partial class LeaseForm : Form
    {
        public LeaseForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxContractStart1.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            textBoxFirstPayment1.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            textBoxAmtPerMonth.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            TextBoxNumOfMonths.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            textBoxVehicleLeased1.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            textBoxCustomer1.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
            textBoxCustomerID1.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
            textBoxLeasedID1.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();
            textBoxVIN1.Text = dataGridView2.SelectedRows[0].Cells[8].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-IJF0QMQ\\MSSQLSERVER2;Initial Catalog=AD_MultiLeaseDB;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("spLeaseInsert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ContractStart", SqlDbType.Date).Value = textBoxContractStart1.Text;
                    cmd.Parameters.Add("@FirstPayment", SqlDbType.Date).Value = textBoxFirstPayment1.Text;
                    cmd.Parameters.Add("@AmtMonthlyPayment", SqlDbType.Money).Value = textBoxAmtPerMonth.Text;
                    cmd.Parameters.Add("@NumMonthlyPayments", SqlDbType.TinyInt).Value = TextBoxNumOfMonths.Text;
                    cmd.Parameters.Add("@VehicleLeased", SqlDbType.NVarChar).Value = textBoxVehicleLeased1.Text;
                    cmd.Parameters.Add("@Customer", SqlDbType.NVarChar).Value = textBoxCustomer1.Text;
                    cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = textBoxCustomerID1.Text;
                    cmd.Parameters.Add("@VehicleLeasedID", SqlDbType.Int).Value = textBoxLeasedID1.Text;
                    cmd.Parameters.Add("@VIN", SqlDbType.NVarChar).Value = textBoxVehicleLeased1.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lease information has successfully been added to MultiLease");
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-IJF0QMQ\\MSSQLSERVER2;Initial Catalog=AD_MultiLeaseDB;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("spUpdateLeaseV5", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ContractStart", SqlDbType.Date).Value = textBoxContractStart1.Text;
                    cmd.Parameters.Add("@FirstPayment", SqlDbType.Date).Value = textBoxFirstPayment1.Text;
                    cmd.Parameters.Add("@AmtMonthlyPayment", SqlDbType.Money).Value = textBoxAmtPerMonth.Text;
                    cmd.Parameters.Add("@NumMonthlyPayments", SqlDbType.TinyInt).Value = TextBoxNumOfMonths.Text;
                    cmd.Parameters.Add("@VehicleLeased", SqlDbType.NVarChar).Value = textBoxVehicleLeased1.Text;
                    cmd.Parameters.Add("@Customer", SqlDbType.NVarChar).Value = textBoxCustomer1.Text;
                    cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = textBoxCustomerID1.Text;
                    cmd.Parameters.Add("@VehicleLeasedID", SqlDbType.Int).Value = textBoxVehicleLeased1.Text;
                    cmd.Parameters.Add("@VIN", SqlDbType.NVarChar).Value = textBoxVehicleLeased1.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lease information has successfully been Updated into MultiLease");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-IJF0QMQ\\MSSQLSERVER2;Initial Catalog=AD_MultiLeaseDB;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("spDeleteLeaseInfo", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                   //cmd.Parameters.Add("@ContractStart", SqlDbType.Date).Value = textBoxContractStart1.Text;
                   //cmd.Parameters.Add("@FirstPayment", SqlDbType.Date).Value = textBoxFirstPayment1.Text;
                   //cmd.Parameters.Add("@AmtMonthlyPayment", SqlDbType.Money).Value = textBoxAmtPerMonth.Text;
                   //cmd.Parameters.Add("@NumMonthlyPayments", SqlDbType.TinyInt).Value = TextBoxNumOfMonths.Text;
                   //cmd.Parameters.Add("@VehicleLeased", SqlDbType.NVarChar).Value = textBoxVehicleLeased1.Text;
                   //cmd.Parameters.Add("@Customer", SqlDbType.NVarChar).Value = textBoxCustomer1.Text;
                   //cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = textBoxCustomerID1.Text;
                     cmd.Parameters.Add("@VehicleLeasedID", SqlDbType.Int).Value = textBoxVehicleLeased1.Text;
                   //cmd.Parameters.Add("@VIN", SqlDbType.NVarChar).Value = textBoxVehicleLeased1.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lease information has deleted from MultiLease");

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-IJF0QMQ\\MSSQLSERVER2;Initial Catalog=AD_MultiLeaseDB;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("spViewLeaseInformation",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable tbl = new DataTable())
                        {
                            sda.Fill(tbl);
                            dataGridView2.DataSource = tbl;
                        }
                    }
                }
            }
        }
    }
}
