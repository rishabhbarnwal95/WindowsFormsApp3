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
    public partial class IDWiseCompany : Form
    {
        public IDWiseCompany()
        {
            InitializeComponent();
        }
        SqlConnection objcon;
        SqlDataAdapter objadapt;
        DataTable objdt;
        private void IDWiseCompany_Load(object sender, EventArgs e)
        {
            string constr = @" Data Source =RISHABH\SQLEXPRESS; Initial Catalog=MedicalShop;integrated Security=sspi";
            objcon = new SqlConnection(constr);
            label1.Visible = false;
            cmbcompanyid.Visible = false;
        }

        private void rbtnidwise_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            cmbcompanyid.Visible = true;
        }

        private void cmbcompanyid_Click(object sender, EventArgs e)
        {
            cmbcompanyid.Items.Clear();
            objadapt = new SqlDataAdapter("Select * from Company", objcon);
            objdt = new DataTable();
            objadapt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbcompanyid.Items.Add(dr["CompanyID"].ToString());
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (rbtnviewall.Checked == true)
            {
                objadapt = new SqlDataAdapter("Select * from Company", objcon);
            }
            else
            {
                if (rbtnidwise.Checked == true)
                {
                    objadapt = new SqlDataAdapter("Select * from Company where CompanyID='" + cmbcompanyid.Text + "'", objcon);
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
