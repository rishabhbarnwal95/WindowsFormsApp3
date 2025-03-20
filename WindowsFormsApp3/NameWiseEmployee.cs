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
    public partial class NameWiseEmployee : Form
    {
        public NameWiseEmployee()
        {
            InitializeComponent();
        }
        SqlConnection objcon;
        SqlDataAdapter objadapt;
        DataTable objdt;
        private void NameWiseEmployee_Load(object sender, EventArgs e)
        {
            String constr;
            constr = @"Data Source=RISHABH\SQLEXPRESS; Initial Catalog=MedicalShop; Integrated Security=sspi";
            objcon = new SqlConnection(constr);
            label1.Visible = false;
            cmbemployeename.Visible = false;
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (rbtnviewall.Checked == true)
            {
                objadapt = new SqlDataAdapter("Select * from Employee", objcon);
            }
            else
            {
                if (rbtnnamewise.Checked == true)
                {
                    objadapt = new SqlDataAdapter("Select * from Employee where EmployeeName='" + cmbemployeename.Text + "'", objcon);
                }
            }
            objdt = new DataTable();
            objadapt.Fill(objdt);
            dataGridView1.DataSource = objdt;
        }

        private void rbtnnamewise_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            cmbemployeename.Visible = true;
        }

        private void cmbemployeename_Click(object sender, EventArgs e)
        {
            cmbemployeename.Items.Clear();
            objadapt = new SqlDataAdapter("Select * from Employee", objcon);
            objdt = new DataTable();
            objadapt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbemployeename.Items.Add(dr["EmployeeName"].ToString());
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
