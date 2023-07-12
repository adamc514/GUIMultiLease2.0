using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUIMultiLease2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
          sqlcon.Open();
          string query = "INSERT INTO Customers(FirstName,LastName,Address,City,Province,PostalCode,PhoneNumber,CustomerID,LeaseID) " +
              "VALUES('"+textBoxFirstName.Text+"','"+textBoxLastName.Text+"','"+textBoxAddress.Text+"','"+textBoxCity.Text+"','"+comboBoxProvince.Text+"','"+textBoxPostalCode.Text+"','"+textBoxPhoneNumber.Text+"','"+textBoxCustID.Text+"','"+textBoxLeaseID.Text+"')";
          SqlCommand cmd = new SqlCommand(query,sqlcon);
          int i = cmd.ExecuteNonQuery();
          if(i != 0)
          {
              MessageBox.Show("Customer has been successfully inserted into MultiLease");
          }
          */
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-IJF0QMQ\\MSSQLSERVER2;Initial Catalog=AD_MultiLeaseDB;Integrated Security=True"))
            {
                using (SqlCommand cmd =  new SqlCommand("spInsertintoCustomer",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = textBoxFirstName1.Text;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = textBoxLastName1.Text;
                    cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = textBoxAddress1.Text;
                    cmd.Parameters.Add("@City", SqlDbType.NVarChar).Value = textBoxCity1.Text;
                    cmd.Parameters.Add("@Province", SqlDbType.NVarChar).Value = comboBoxProvince1.Text;
                    cmd.Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value = textBoxPostalCode1.Text;
                    cmd.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = textBoxPhoneNumber1.Text;
                    cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar).Value = textBoxCustID1.Text;
                    cmd.Parameters.Add("@LeaseID", SqlDbType.NVarChar).Value = textBoxLeaseID1.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Information has successfully been added to MultiLease");
                    

                }
            }

            /*
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("spInsertintoCustomer", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Customer has successfully been added into MultiLease");
              */
        }

        private void View_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-IJF0QMQ\\MSSQLSERVER2;Initial Catalog=AD_MultiLeaseDB;Integrated Security=True"))
            {
                using (SqlCommand cmd =  new SqlCommand("spViewCustomerInfo", con))
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

        private void Update_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-IJF0QMQ\\MSSQLSERVER2;Initial Catalog=AD_MultiLeaseDB;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("spUpdateCustomer", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = textBoxFirstName1.Text;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = textBoxLastName1.Text;
                    cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = textBoxAddress1.Text;
                    cmd.Parameters.Add("@City", SqlDbType.NVarChar).Value = textBoxCity1.Text;
                    cmd.Parameters.Add("@Province", SqlDbType.NVarChar).Value = comboBoxProvince1.Text;
                    cmd.Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value = textBoxPostalCode1.Text;
                    cmd.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = textBoxPhoneNumber1.Text;
                    cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar).Value = textBoxCustID1.Text;
                    cmd.Parameters.Add("@LeaseID", SqlDbType.NVarChar).Value = textBoxLeaseID1.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Information has successfully been updated!");
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-IJF0QMQ\\MSSQLSERVER2;Initial Catalog=AD_MultiLeaseDB;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("spDeleteCustomerInfo", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = textBoxFirstName1.Text;
                    //cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = textBoxLastName1.Text;
                    //cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = textBoxAddress1.Text;
                    //cmd.Parameters.Add("@City", SqlDbType.NVarChar).Value = textBoxCity1.Text;
                    //cmd.Parameters.Add("@Province", SqlDbType.NVarChar).Value = comboBoxProvince1.Text;
                    //cmd.Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value = textBoxPostalCode1.Text;
                    //cmd.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = textBoxPhoneNumber1.Text;
                    //cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar).Value = textBoxCustID1.Text;
                    cmd.Parameters.Add("@LeaseID", SqlDbType.NVarChar).Value = textBoxLeaseID1.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Information has successfully been deleted!");
                }
            }

            /*
    try
    {
        sqlcon.Open();
        // "', LastName = '" + textBoxLastName.Text + "', Address = '"+textBoxAddress.Text+"', City = '"+comboBoxProvince.Text+"', PostalCode = '"+textBoxPostalCode.Text+"', PhoneNumber = '"+textBoxPhoneNumber.Text+"', CustomerID = '"+textBoxCustID.Text+"', LeaseID = '"+textBoxLeaseID.Text+"'
        string query = "DELETE FROM Customers WHERE FirstName = '" + textBoxFirstName.Text + "'";
        SqlCommand cmd = new SqlCommand(query, sqlcon);
        cmd.ExecuteNonQuery();
        MessageBox.Show("Customer Data has successfully been deleted");
        sqlcon.Close();

    }
    catch(Exception ex)
    {
        MessageBox.Show("Error has occured",ex.Message);
    }
    */
        }

        private void Lease_Click(object sender, EventArgs e)
        {
            LeaseForm lsfrm = new LeaseForm();
            this.Hide();
            lsfrm.ShowDialog();

        }

        private void Audit_Click(object sender, EventArgs e)
        {
            AuditsForm af = new AuditsForm();
            this.Hide();
            af.ShowDialog();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxFirstName1.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            textBoxLastName1.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            textBoxAddress1.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            textBoxCity1.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            comboBoxProvince1.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            textBoxPostalCode1.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
            textBoxPhoneNumber1.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
            textBoxCustID1.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();
            textBoxLeaseID1.Text = dataGridView2.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
