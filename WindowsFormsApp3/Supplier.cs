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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }
        SqlConnection objcon;
        SqlCommand objcomm;
        SqlDataAdapter objadapt;
        DataTable objdt;
        private void Supplier_Load(object sender, EventArgs e)
        {
            string constr;
            constr = @"data source=RISHABH\SQLEXPRESS;initial catalog=MedicalShop;integrated security=sspi";
            objcon = new SqlConnection(constr);
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
        }
        string mode;
        private void btnadd_Click(object sender, EventArgs e)
        {
            mode = "Add";
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            txtsupplierid.Visible = true;
            cmbsupplierid.Visible = false;
            cmbcompanyid.Visible = true;
            txtsuppliername.Visible = true;
            cmbmedicinecode.Visible = true;
            txtaddress.Visible = true;
            txtemail.Visible = true;
            txtphone.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            txtsupplierid.Text = "";
            txtsuppliername.Text = "";
            cmbcompanyid.Text = "";
            cmbmedicinecode.Text = "";
            txtaddress.Text = "";
            txtphone.Text = "";
            txtemail.Text = "";
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            mode = "Update";
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            cmbsupplierid.Visible = true;
            txtsupplierid.Visible = false;
            txtsuppliername.Visible = true;
            cmbcompanyid.Visible = true;
            cmbmedicinecode.Visible = true;
            txtaddress.Visible = true;
            txtemail.Visible = true;
            txtphone.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            cmbsupplierid.Text = "";
            cmbcompanyid.Text = "";
            cmbmedicinecode.Text = "";
            txtaddress.Text = "";
            txtemail.Text = "";
            txtphone.Text = "";
            txtsuppliername.Text = "";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            mode = "Delete";
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            cmbsupplierid.Visible = true;
            txtsupplierid.Visible = false;
            cmbcompanyid.Visible = false;
            cmbmedicinecode.Visible = false;
            txtaddress.Visible = false;
            txtemail.Visible = false;
            txtphone.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            txtsuppliername.Enabled = false;
            cmbsupplierid.Text = "";
            txtsuppliername.Text = "";
        }

        private void btmsave_Click(object sender, EventArgs e)
        {
            if (mode == "Add")
            {
                objadapt = new SqlDataAdapter("Select * from Supplier where SupplierID='" + cmbsupplierid.Text + "'", objcon);
                objdt = new DataTable();
                objadapt.Fill(objdt);
                if (objdt.Rows.Count > 0)
                {
                    MessageBox.Show("Supplier ID Already exist...");
                    cmbsupplierid.Text = "";
                    txtsupplierid.Focus();
                }
                if (txtsuppliername.Text == "")
                {
                    MessageBox.Show("Enter Supplier Name...");
                    txtsuppliername.Focus();
                }
                if (cmbcompanyid.Text == "")
                {
                    MessageBox.Show("Enter Company ID...");
                    cmbcompanyid.Focus();
                }
                if (cmbmedicinecode.Text == "")
                {
                    MessageBox.Show("Enter Medicine Code...");
                    cmbmedicinecode.Focus();
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
                    objcomm = new SqlCommand("insert into Supplier(SupplierID,SupplierName,CompanyID,MedicineCode,Address,Phone,Email)values('" + txtsupplierid.Text + "','" + txtsuppliername.Text + "','" + cmbcompanyid.Text + "','" + cmbmedicinecode.Text + "','" + txtaddress.Text + "','" + txtphone.Text + "','" + txtemail.Text + "')", objcon);
                    objcon.Open();
                    objcomm.ExecuteNonQuery();
                    objcon.Close();
                    MessageBox.Show("One row inserted");
                    txtsupplierid.Text = "";
                    txtsuppliername.Text = "";
                    cmbcompanyid.Text = "";
                    cmbmedicinecode.Text = "";
                    txtaddress.Text = "";
                    txtphone.Text = "";
                    txtemail.Text = "";
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;
                }
            }
            if (mode == "Update")
            {
                objcomm = new SqlCommand("update Supplier set Address='" + txtaddress.Text + "',Phone='" + txtphone.Text + "',Email='" + txtemail.Text + "' where SupplierID='" + cmbsupplierid.Text + "'", objcon);
                objcon.Open();
                objcomm.ExecuteNonQuery();
                objcon.Close();
                MessageBox.Show("One record update");

                txtsuppliername.Text = "";
                cmbcompanyid.Text = "";
                cmbmedicinecode.Text = "";
                txtaddress.Text = "";
                txtphone.Text = "";
                txtemail.Text = "";
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
            }
            if (mode == "Delete")
            {
                objcomm = new SqlCommand("delete Supplier where SupplierId='" + cmbsupplierid.Text + "'", objcon);
                objcon.Open();
                objcomm.ExecuteNonQuery();
                objcon.Close();
                MessageBox.Show("One row deleted");
                cmbsupplierid.Text = "";
                cmbcompanyid.Text = "";
                cmbmedicinecode.Text = "";
                txtaddress.Text = "";
                txtemail.Text = "";
                txtphone.Text = "";
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                cmbcompanyid.Visible = true;
                cmbmedicinecode.Visible = true;
                txtsupplierid.Visible = true;
                txtaddress.Visible = true;
                txtemail.Visible = true;
                txtphone.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                txtsuppliername.Enabled = false;
            }
        }

        private void cmbsupplierid_Click(object sender, EventArgs e)
        {
            cmbsupplierid.Items.Clear();
            objadapt = new SqlDataAdapter("Select * from Supplier", objcon);
            objdt = new DataTable();
            objadapt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbsupplierid.Items.Add(dr["SupplierID"]).ToString();
            }
        }

        private void cmbsupplierid_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtsuppliername.Text = objdt.Rows[cmbsupplierid.SelectedIndex]["SupplierName"].ToString();
            cmbcompanyid.Text = objdt.Rows[cmbsupplierid.SelectedIndex]["CompanyID"].ToString();
            cmbmedicinecode.Text = objdt.Rows[cmbsupplierid.SelectedIndex]["Medicinecode"].ToString();
            txtaddress.Text = objdt.Rows[cmbsupplierid.SelectedIndex]["Address"].ToString();
            txtphone.Text = objdt.Rows[cmbsupplierid.SelectedIndex]["Phone"].ToString();
            txtemail.Text = objdt.Rows[cmbsupplierid.SelectedIndex]["Email"].ToString();
        }

        private void cmbcompanyid_Click(object sender, EventArgs e)
        {
            cmbcompanyid.Items.Clear();
            objadapt = new SqlDataAdapter("select * from Company", objcon);
            objdt = new DataTable();
            objadapt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbcompanyid.Items.Add(dr["CompanyID"].ToString());

            }
        }

        private void cmbmedicinecode_Click(object sender, EventArgs e)
        {
            cmbmedicinecode.Items.Clear();
            objadapt = new SqlDataAdapter("select * from Medicine", objcon);
            objdt = new DataTable();
            objadapt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbmedicinecode.Items.Add(dr["MedicineId"].ToString());

            }
        }

        private void btmcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
