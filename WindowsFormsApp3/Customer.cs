using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        SqlConnection objcon;
        SqlCommand objcomm;
        SqlDataAdapter objadapt;
        DataTable objdt;
        private void Customer_Load(object sender, EventArgs e)
        {
            string constr = @"data source=RISHABH\SQLEXPRESS; initial catalog=MedicalShop;integrated security=sspi";
            objcon = new SqlConnection(constr);
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
        }
        String mode;

        private void btnadd_Click(object sender, EventArgs e)
        {
            mode = "Add";
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            txtcustomerid.Visible = true;
            cmbcustomerid.Visible = false;

            txtaddress.Visible = true;
            txtphone.Visible = true;
            txtemail.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            txtname.Enabled = true;

            cmbcustomerid.Text = "";
            txtaddress.Text = "";
            txtemail.Text = "";
            txtname.Text = "";
            txtphone.Text = "";
        }

        private void cmbcustomerid_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtname.Text = objdt.Rows[cmbcustomerid.SelectedIndex]["CustomerName"].ToString();
            txtaddress.Text = objdt.Rows[cmbcustomerid.SelectedIndex]["Address"].ToString();
            txtphone.Text = objdt.Rows[cmbcustomerid.SelectedIndex]["Phone"].ToString();
            txtemail.Text = objdt.Rows[cmbcustomerid.SelectedIndex]["Email"].ToString();
        }

        private void cmbcustomerid_Click(object sender, EventArgs e)
        {
            cmbcustomerid.Items.Clear();
            objadapt = new SqlDataAdapter("Select * from customer", objcon);
            objdt = new DataTable();
            objadapt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbcustomerid.Items.Add(dr["CustomerID"].ToString());
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            mode = "Update";
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            cmbcustomerid.Visible = true;
            txtcustomerid.Visible = false;
            txtaddress.Visible = true;
            txtphone.Visible = true;
            txtemail.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            txtname.Enabled = true;
            cmbcustomerid.Text = "";
            txtaddress.Text = "";
            txtemail.Text = "";
            txtname.Text = "";
            txtphone.Text = "";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            mode = "Delete";
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            cmbcustomerid.Visible = true;
            txtcustomerid.Visible = false;
            txtaddress.Visible = false;
            txtphone.Visible = false;
            txtemail.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            txtname.Enabled = false;
            cmbcustomerid.Text = "";
            txtname.Text = "";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (mode == "Add")
            {
                cmbcustomerid.Items.Clear();
                objadapt = new SqlDataAdapter("Select * from Customer where CustomerID='" + cmbcustomerid.Text + "'", objcon);
                objdt = new DataTable();
                objadapt.Fill(objdt);
                if (objdt.Rows.Count > 0)
                {
                    MessageBox.Show("CustomerID already exist...");
                    cmbcustomerid.Text = "";
                    txtcustomerid.Focus();
                }
                if (txtname.Text == "")
                {
                    MessageBox.Show("Enter Name...");
                    txtname.Focus();
                }
                if (txtaddress.Text == "")
                {
                    MessageBox.Show("Enter Address...");
                    txtaddress.Focus();
                }
                if (txtphone.Text == "")
                {
                    MessageBox.Show("Enter Phone...");
                    txtphone.Focus();
                }
                if (txtemail.Text == "")
                {
                    MessageBox.Show("Enter Email...");
                    txtemail.Focus();
                }

                else
                {
                    objcomm = new SqlCommand("insert into Customer(CustomerID,CustomerName,Address,Phone,Email)values('" + txtcustomerid.Text + "','" + txtname.Text + "','" + txtaddress.Text + "','" + txtphone.Text + "','" + txtemail.Text + "')", objcon);
                    objcon.Open();
                    objcomm.ExecuteNonQuery();
                    objcon.Close();
                    MessageBox.Show("One record inserted");
                    txtcustomerid.Text = "";
                    txtname.Text = "";
                    txtaddress.Text = "";
                    txtphone.Text = "";
                    txtemail.Text = "";
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;
                }
            }
            if (mode == "Update")
            {
                objcomm = new SqlCommand("Update customer set CustomerName='" + txtname.Text + "',Address='" + txtaddress.Text + "',Phone='" + txtphone.Text + "',Email='" + txtemail.Text + "' where CustomerID='" + cmbcustomerid.Text + "'", objcon);
                objcon.Open();
                objcomm.ExecuteNonQuery();
                objcon.Close();
                MessageBox.Show("One record updated");
                txtname.Text = "";
                txtaddress.Text = "";
                txtphone.Text = "";
                txtemail.Text = "";
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                cmbcustomerid.Visible = false;
                txtcustomerid.Visible = true;
            }
            if (mode == "Delete")
            {
                objcomm = new SqlCommand("Delete Customer where customerId='" + cmbcustomerid.Text + "'", objcon);
                objcon.Open();
                objcomm.ExecuteNonQuery();
                objcon.Close();
                MessageBox.Show("One row deleted");
                cmbcustomerid.Text = "";
                txtaddress.Text = "";
                txtemail.Text = "";
                txtname.Text = "";
                txtphone.Text = "";
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                cmbcustomerid.Visible = false;
                txtcustomerid.Visible = true;
                txtaddress.Visible = true;
                txtemail.Visible = true;
                txtname.Visible = true;
                txtphone.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                txtname.Enabled = true;
            }
        }

        private void btmcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
