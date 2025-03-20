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
    public partial class IDWiseCustomer : Form
    {
        public IDWiseCustomer()
        {
            InitializeComponent();
        }
        SqlConnection objcon;
        SqlDataAdapter objadapt;
        DataTable objdt;
        private void IDWiseCustomer_Load(object sender, EventArgs e)
        {
            string constr = @" Data Source =RISHABH\SQLEXPRESS; Initial Catalog=MedicalShop;integrated Security=sspi";
            objcon = new SqlConnection(constr);
            label1.Visible = false;
            cmbcustomerid.Visible = false;
        }

        private void rbtnidwise_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            cmbcustomerid.Visible = true;
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (rbtnviewall.Checked == true)
            {
                objadapt = new SqlDataAdapter("Select * from Customer", objcon);
            }
            else
            {
                if (rbtnidwise.Checked == true)
                {
                    objadapt = new SqlDataAdapter("Select * from Customer where CustomerID='" + cmbcustomerid.Text + "'", objcon);
                }
            }
            objdt = new DataTable();
            objadapt.Fill(objdt);
            dataGridView1.DataSource = objdt;
        }

        private void cmbcustomerid_Click(object sender, EventArgs e)
        {
            cmbcustomerid.Items.Clear();
            objadapt = new SqlDataAdapter("Select * from Customer", objcon);
            objdt = new DataTable();
            objadapt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbcustomerid.Items.Add(dr["CustomerID"].ToString());
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
