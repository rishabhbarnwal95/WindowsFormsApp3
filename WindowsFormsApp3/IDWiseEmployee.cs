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
    public partial class IDWiseEmployee : Form
    {
        public IDWiseEmployee()
        {
            InitializeComponent();
        }
        SqlConnection objcon;
        SqlDataAdapter objadapt;
        DataTable objdt;
        private void IDWiseEmployee_Load(object sender, EventArgs e)
        {
            string constr = @"Data Source=RISHABH\SQLEXPRESS;Initial Catalog=MedicalShop;Integrated Security=sspi";
            objcon = new SqlConnection(constr);
            label1.Visible = false;
            cmbemployeeid.Visible = false;
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (rbtnviewall.Checked == true)
            {
                objadapt = new SqlDataAdapter("Select * from Employee", objcon);
            }
            else
            {
                if (rbtnidwise.Checked == true)
                {
                    objadapt = new SqlDataAdapter("Select * from Employee where EmployeeID='" + cmbemployeeid.Text + "'", objcon);
                }
            }
            objdt = new DataTable();
            objadapt.Fill(objdt);
            dataGridView1.DataSource = objdt;
        }

        private void rbtnidwise_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            cmbemployeeid.Visible = true;
        }

        private void cmbemployeeid_Click(object sender, EventArgs e)
        {
            cmbemployeeid.Items.Clear();
            objadapt = new SqlDataAdapter("Select * from Employee", objcon);
            objdt = new DataTable();
            objadapt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbemployeeid.Items.Add(dr["EmployeeID"].ToString());
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
