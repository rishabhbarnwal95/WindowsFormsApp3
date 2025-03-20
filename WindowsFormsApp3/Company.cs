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
    public partial class Company : Form
    {
        public Company()
        {
            InitializeComponent();
        }
        SqlConnection objcon;
        SqlCommand objcomm;
        SqlDataAdapter objadapt;
        DataTable objdt;
        private void Company_Load(object sender, EventArgs e)
        {
            string constr = @"data source=RISHABH\SQLEXPRESS; initial catalog=MedicalShop;integrated security=sspi";
            objcon = new SqlConnection(constr);
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            cmbcomid.Visible = false;
        }
        string mode;

        private void btnadd_Click(object sender, EventArgs e)
        {
            mode = "Add";
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            txtcompanyid.Visible = true;
            txtname.Visible = true;
            txtemail.Visible = true;
            txtwebsite.Visible = true;
            txtaddress.Visible = true;
            txtphone.Visible = true;
            label2.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label3.Visible = true;
            label6.Visible = true;
            cmbcomid.Visible = false;
            txtcompanyid.Text = "";
            txtname.Text = "";
            txtaddress.Text = "";
            txtemail.Text = "";
            txtphone.Text = "";
            txtwebsite.Text = "";
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            mode = "Update";
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            cmbcomid.Visible = true;
            txtcompanyid.Visible = false;
            txtname.Visible = true;
            txtemail.Visible = true;
            txtwebsite.Visible = true;
            txtaddress.Visible = true;
            txtphone.Visible = true;
            label2.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label3.Visible = true;
            label6.Visible = true;
            cmbcomid.Text = "";
            txtname.Text = "";
            txtaddress.Text = "";
            txtemail.Text = "";
            txtphone.Text = "";
            txtwebsite.Text = "";
            txtname.Enabled = true;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            mode = "Delete";
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            cmbcomid.Visible = true;
            txtcompanyid.Visible = false;
            txtaddress.Visible = false;
            txtphone.Visible = false;
            txtemail.Visible = false;
            txtwebsite.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            txtname.Enabled = false;
            cmbcomid.Text = "";
            txtname.Text = "";
        }

        private void cmbcomid_Click(object sender, EventArgs e)
        {
            cmbcomid.Items.Clear();
            objadapt = new SqlDataAdapter("select * from Company", objcon);
            objdt = new DataTable();
            objadapt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbcomid.Items.Add(dr["CompanyID"].ToString());
            }
        }

        private void btmsave_Click(object sender, EventArgs e)
        {
            if (mode == "Add")
            {
                cmbcomid.Items.Clear();
                objadapt = new SqlDataAdapter("Select * from Company where CompanyID='" + cmbcomid.Text + "'", objcon);
                objdt = new DataTable();
                objadapt.Fill(objdt);
                if (objdt.Rows.Count > 0)
                {
                    MessageBox.Show("Company ID already exist...");
                    cmbcomid.Text = "";
                    txtcompanyid.Focus();
                }
                if (txtcompanyid.Text == "")
                {
                    MessageBox.Show("Enter the Company ID...");
                    txtcompanyid.Focus();
                }
                if (txtname.Text == "")
                {
                    MessageBox.Show("Enter the Company Name...");
                    txtaddress.Focus();
                }
                if (txtaddress.Text == "")
                {
                    MessageBox.Show("Enter the Address...");
                    txtaddress.Focus();
                }
                if (txtphone.Text == "")
                {
                    MessageBox.Show("Enter the Phone...");
                    txtphone.Focus();
                }
                if (txtemail.Text == "")
                {
                    MessageBox.Show("Enter the Email...");
                    txtemail.Focus();
                }
                if (txtwebsite.Text == "")
                {
                    MessageBox.Show("Enter the Website...");
                    txtwebsite.Focus();
                }

                else
                {

                    objcomm = new SqlCommand("insert into company(CompanyID,CompanyName,Address,Phone,Email,Website) values('" + txtcompanyid.Text + "','" + txtname.Text + "','" + txtaddress.Text + "','" + txtphone.Text + "','" + txtemail.Text + "','" + txtwebsite.Text + "')", objcon);
                    objcon.Open();
                    objcomm.ExecuteNonQuery();
                    objcon.Close();
                    MessageBox.Show("One Record Inserted...");
                    txtcompanyid.Text = "";
                    txtname.Text = "";
                    txtaddress.Text = "";
                    txtphone.Text = "";
                    txtemail.Text = "";
                    txtwebsite.Text = "";
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;
                }

            }
            if (mode == "Update")
            {
                objcomm = new SqlCommand("update Company set Address='" + txtaddress.Text + "',Email='" + txtemail.Text + "',Phone='" + txtphone.Text + "',Website='" + txtwebsite.Text + "' where CompanyID='" + cmbcomid.Text + "'", objcon);
                objcon.Open();
                objcomm.ExecuteNonQuery();
                objcon.Close();
                MessageBox.Show("One row updated");
                cmbcomid.Text = "";
                txtemail.Text = "";
                txtname.Text = "";
                txtphone.Text = "";
                txtwebsite.Text = "";
                txtaddress.Text = "";
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                cmbcomid.Visible = false;
                txtcompanyid.Visible = true;
            }
            if (mode == "Delete")
            {
                objcomm = new SqlCommand("delete Company  where CompanyID='" + cmbcomid.Text + "'", objcon);
                objcon.Open();
                objcomm.ExecuteNonQuery();
                objcon.Close();
                MessageBox.Show("One row Deleted");
                cmbcomid.Text = "";
                txtemail.Text = "";
                txtname.Text = "";
                txtphone.Text = "";
                txtwebsite.Text = "";
                txtaddress.Text = "";
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                cmbcomid.Visible = false;
                txtcompanyid.Visible = true;
                txtaddress.Visible = true;
                txtphone.Visible = true;
                txtemail.Visible = true;
                txtwebsite.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                txtname.Enabled = true;

            }
        }

        private void cmbcomid_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtaddress.Text = objdt.Rows[cmbcomid.SelectedIndex]["Address"].ToString();
            txtname.Text = objdt.Rows[cmbcomid.SelectedIndex]["companyname"].ToString();
            txtphone.Text = objdt.Rows[cmbcomid.SelectedIndex]["Phone"].ToString();
            txtemail.Text = objdt.Rows[cmbcomid.SelectedIndex]["Email"].ToString();
            txtwebsite.Text = objdt.Rows[cmbcomid.SelectedIndex]["Website"].ToString();
        }

        private void btmcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
