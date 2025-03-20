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
    public partial class IDWiseSupplier : Form
    {
        public IDWiseSupplier()
        {
            InitializeComponent();
        }
        SqlConnection objcon;
        SqlDataAdapter objadapt;
        DataTable objdt;
        private void IDWiseSupplier_Load(object sender, EventArgs e)
        {
            string constr;
            constr = @"Data Source=RISHABH\SQLEXPRESS;Initial Catalog=MedicalShop;Integrated Security=sspi";
            objcon = new SqlConnection(constr);
            label1.Visible = false;
            cmbsupplierid.Visible = false;
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
                    objadapt = new SqlDataAdapter("Select * from Supplier where SupplierID='" + cmbsupplierid.Text + "'", objcon);
                }
            }
            objdt = new DataTable();
            objadapt.Fill(objdt);
            dataGridView1.DataSource = objdt;
        }

        private void rbtnidwise_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            cmbsupplierid.Visible = true;
        }

        private void cmbsupplierid_Click(object sender, EventArgs e)
        {
            cmbsupplierid.Items.Clear();
            objadapt = new SqlDataAdapter("Select * from Supplier", objcon);
            objdt = new DataTable();
            objadapt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbsupplierid.Items.Add(dr["SupplierID"].ToString());
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
