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
    public partial class NameWiseCustomer : Form
    {
        public NameWiseCustomer()
        {
            InitializeComponent();
        }
        SqlConnection objcon;
        SqlDataAdapter objadapt;
        DataTable objdt;
        private void NameWiseCustomer_Load(object sender, EventArgs e)
        {
            String constr;
            constr = @"Data Source=RISHABH\SQLEXPRESS; Initial Catalog=MedicalShop; Integrated Security=sspi";
            objcon = new SqlConnection(constr);
            label1.Visible = false;
            cmbcustomername.Visible = false;
        }

        private void rbtnnamewise_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            cmbcustomername.Visible = true;
        }

        private void cmbcustomername_Click(object sender, EventArgs e)
        {
            cmbcustomername.Items.Clear();
            objadapt = new SqlDataAdapter("Select * from Customer", objcon);
            objdt = new DataTable();
            objadapt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbcustomername.Items.Add(dr["CustomerName"].ToString());
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (rbtnviewall.Checked == true)
            {
                objadapt = new SqlDataAdapter("Select * from Customer", objcon);
            }
            else
            {
                if (rbtnnamewise.Checked == true)
                {
                    objadapt = new SqlDataAdapter("Select * from Customer where CustomerName='" + cmbcustomername.Text + "'", objcon);
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
