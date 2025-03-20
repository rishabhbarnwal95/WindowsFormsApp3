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
    public partial class VoucharSale : Form
    {
        public VoucharSale()
        {
            InitializeComponent();
        }
        SqlConnection objcon;
        SqlDataAdapter objadapt;
        DataTable objdt;
        private void VoucharSale_Load(object sender, EventArgs e)
        {
            string constr = @"data source=RISHABH\SQLEXPRESS;initial catalog=MedicalShop;integrated security=sspi";
            objcon = new SqlConnection(constr);
            label1.Visible = false;
            cmbvoucharnumber.Visible = false;
        }

        private void cmbvoucharnumber_Click(object sender, EventArgs e)
        {
            cmbvoucharnumber.Items.Clear();
            objadapt = new SqlDataAdapter("Select * from Sale", objcon);
            objdt = new DataTable();
            objadapt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbvoucharnumber.Items.Add(dr["VoucharNumber"].ToString());
            }
        }

        private void rbtnidwise_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            cmbvoucharnumber.Visible = true;
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (rbtnviewall.Checked == true)
            {

                objadapt = new SqlDataAdapter("Select * from Sale", objcon);
            }
            else
            {
                if (rbtnidwise.Checked == true)
                {
                    objadapt = new SqlDataAdapter("Select * from Company where CompanyName='" + cmbvoucharnumber.Text + "'", objcon);
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
