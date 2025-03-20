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
    public partial class Medicine : Form
    {
        public Medicine()
        {
            InitializeComponent();
        }
        SqlConnection objcon;
        SqlCommand objcomm;
        SqlDataAdapter objadapt;
        DataTable objdt;
        private void Medicine_Load(object sender, EventArgs e)
        {
            string constr;
            constr = @"data source=RISHABH\SQLEXPRESS;initial catalog=MedicalShop;integrated security=sspi";
            objcon = new SqlConnection(constr);
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            cmbcompanyid.Visible = true;
        }
        string mode;

        private void btnadd_Click(object sender, EventArgs e)
        {
            mode = "Add";
            txtmedicinecode.Visible = true;
            cmbmedicinecode.Visible = false;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            txtmedicinename.Text = "";
            cmbcompanyid.Text = "";
            Dtpmanufacturingdate.Text = "";
            Dtpexpirydate.Text = "";
            txtpower.Text = "";
            txtprice.Text = "";
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            mode = "Update";
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            cmbmedicinecode.Visible = true;
            txtmedicinecode.Visible = false;
            cmbcompanyid.Visible = true;
            Dtpexpirydate.Visible = true;
            Dtpmanufacturingdate.Visible = true;
            txtprice.Visible = true;
            txtpower.Visible = true;
            txtmedicinename.Enabled = true;
            label5.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label7.Visible = true;
            label2.Visible = true;
            label6.Visible = true;
            cmbmedicinecode.Text = "";
            txtmedicinename.Text = "";
            Dtpexpirydate.Text = "";
            Dtpmanufacturingdate.Text = "";
            txtpower.Text = "";
            txtprice.Text = "";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            mode = "Delete";
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            cmbmedicinecode.Visible = true;
            txtmedicinecode.Visible = false;
            txtmedicinecode.Visible = false;
            cmbcompanyid.Visible = false;
            Dtpexpirydate.Visible = false;
            Dtpmanufacturingdate.Visible = false;
            txtprice.Visible = false;
            txtpower.Visible = false;
            txtmedicinename.Enabled = true;
            label5.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            label7.Visible = false;
            label2.Visible = true;
            label6.Visible = false;
            cmbmedicinecode.Text = "";
            txtmedicinename.Text = "";
            txtmedicinename.Enabled = false;
        }

        private void btmsave_Click(object sender, EventArgs e)
        {
            if (mode == "Add")
            {
                objadapt = new SqlDataAdapter("select * from Medicine where MedicineId='" + txtmedicinecode.Text + "'", objcon);
                objdt = new DataTable();
                objadapt.Fill(objdt);
                if (objdt.Rows.Count > 0)
                {
                    MessageBox.Show("Medicine code already exist...");
                    txtmedicinecode.Text = "";
                    txtmedicinecode.Focus();
                }
                if (txtmedicinecode.Text == "")
                {
                    MessageBox.Show("Enter the Medicine Code...");
                    txtmedicinecode.Focus();
                }
                if (txtmedicinename.Text == "")
                {
                    MessageBox.Show("Enter the Medicine Name...");
                    txtmedicinename.Focus();
                }
                if (cmbcompanyid.Text == "")
                {
                    MessageBox.Show("Enter the Company ID ..");
                    cmbcompanyid.Focus();
                }
                if (txtprice.Text == "")
                {
                    MessageBox.Show("Enter the Medicine Price..");
                    txtprice.Focus();
                }
                if (txtpower.Text == "")
                {
                    MessageBox.Show("Enter the Medicine Power..");
                    txtpower.Focus();
                }

                else
                {
                    objcomm = new SqlCommand("insert into Medicine(MedicineId,MedicineName,CompanyID,ManufacturingDate,ExpiryDate,Price,Power)values('" + txtmedicinecode.Text + "','" + txtmedicinename.Text + "','" + cmbcompanyid.Text + "','" + Dtpmanufacturingdate.Value + "','" + Dtpexpirydate.Value + "','" + txtprice.Text + "','" + txtpower.Text + "')", objcon);
                    objcon.Open();
                    objcomm.ExecuteNonQuery();
                    objcon.Close();
                    MessageBox.Show("One row inserted");
                    txtmedicinecode.Text = "";
                    txtmedicinename.Text = "";

                    txtprice.Text = "";
                    txtpower.Text = "";
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;
                }
            }
            if (mode == "Update")
            {
                objcomm = new SqlCommand("update Medicine set MedicineId='" + txtmedicinecode.Text + "',ManufacturingDate='" + Dtpmanufacturingdate.Value + "',ExpiryDate='" + Dtpexpirydate.Value + "',Price='" + txtprice.Text + "',Power='" + txtpower.Text + "' where CompanyId='" + cmbcompanyid + "'", objcon);
                objcon.Open();
                objcomm.ExecuteNonQuery();
                objcon.Close();
                MessageBox.Show("One row updated");
                cmbcompanyid.Text = "";
                txtmedicinename.Text = "";
                txtmedicinecode.Text = "";
                txtprice.Text = "";
                txtpower.Text = "";
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;


            }
            if (mode == "Delete")
            {
                objcomm = new SqlCommand("delete from Medicine  where MedicineId='" + cmbmedicinecode.Text + "'", objcon);
                objcon.Open();
                objcomm.ExecuteNonQuery();
                MessageBox.Show("One record deleted");
                objcon.Close();
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                txtmedicinename.Text = "";
                cmbcompanyid.Text = "";
                txtmedicinecode.Text = "";
                txtpower.Text = "";
                txtprice.Text = "";
                cmbmedicinecode.Text = "";
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

        private void cmbmedicinecode_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtmedicinename.Text = objdt.Rows[cmbmedicinecode.SelectedIndex]["MedicineName"].ToString();
            Dtpmanufacturingdate.Text = objdt.Rows[cmbmedicinecode.SelectedIndex]["ManufacturingDate"].ToString();
            Dtpexpirydate.Text = objdt.Rows[cmbmedicinecode.SelectedIndex]["ExpiryDate"].ToString();
            txtprice.Text = objdt.Rows[cmbmedicinecode.SelectedIndex]["Price"].ToString();
            txtpower.Text = objdt.Rows[cmbmedicinecode.SelectedIndex]["Power"].ToString();
        }

        private void btmcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
