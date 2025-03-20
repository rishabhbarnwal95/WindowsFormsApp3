using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class VoucharPurchase : Form
    {
        public VoucharPurchase()
        {
            InitializeComponent();
        }
        SqlConnection objcon;
        SqlDataAdapter objadapt;
        DataTable objdt;
        private void VoucharPurchase_Load(object sender, EventArgs e)
        {
            string constr = @"data source=RISHABH\SQLEXPRESS;initial catalog=MedicalShop;integrated security=sspi";
            objcon = new SqlConnection(constr);
            label1.Visible = false;
            cmbvoucharnum.Visible = false;
        }

        private void cmbvoucharnum_Click(object sender, EventArgs e)
        {
            cmbvoucharnum.Items.Clear();
            objadapt = new SqlDataAdapter("Select * from Purchase", objcon);
            objdt = new DataTable();
            objadapt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbvoucharnum.Items.Add(dr["VoucharNumber"].ToString());
            }
        }

        private void rbtnidwise_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            cmbvoucharnum.Visible = true;
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (rbtnviewall.Checked == true)
            {

                objadapt = new SqlDataAdapter("Select * from Purchase", objcon);
            }
            else
            {
                if (rbtnidwise.Checked == true)
                {
                    objadapt = new SqlDataAdapter("Select * from Company where CompanyName='" + cmbvoucharnum.Text + "'", objcon);
                }
            }
            objdt = new DataTable();
            objadapt.Fill(objdt);
            dataGridView1.DataSource = objdt;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
