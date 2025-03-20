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
    public partial class NameWiseSupplier : Form
    {
        public NameWiseSupplier()
        {
            InitializeComponent();
        }
        SqlConnection objcon;
        SqlDataAdapter objadapt;
        DataTable objdt;
        private void NameWiseSupplier_Load(object sender, EventArgs e)
        {
            String constr;
            constr = @"Data Source=RISHABH\SQLEXPRESS; Initial Catalog=MedicalShop; Integrated Security=sspi";
            objcon = new SqlConnection(constr);
            label1.Visible = false;
            cmbsuppliername.Visible = false;
        }

        private void rbtnidwise_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            cmbsuppliername.Visible = true;
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (rbtnviewall.Checked == true)
            {
                objadapt = new SqlDataAdapter("Select * from Supplier", objcon);
            }
            else
            {
                if (rbtnidwise.Checked == true)
                {
                    objadapt = new SqlDataAdapter("Select * from Supplier where SupplierName='" + cmbsuppliername.Text + "'", objcon);
                }
            }
            objdt = new DataTable();
            objadapt.Fill(objdt);
            dataGridView1.DataSource = objdt;
        }

        private void cmbsuppliername_Click(object sender, EventArgs e)
        {
            cmbsuppliername.Items.Clear();
            objadapt = new SqlDataAdapter("Select * from Supplier", objcon);
            objdt = new DataTable();
            objadapt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbsuppliername.Items.Add(dr["SupplierName"].ToString());
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
