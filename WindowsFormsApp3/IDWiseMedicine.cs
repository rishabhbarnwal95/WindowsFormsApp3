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
    public partial class IDWiseMedicine : Form
    {
        public IDWiseMedicine()
        {
            InitializeComponent();
        }
        SqlConnection objcon;
        SqlDataAdapter objadapt;
        DataTable objdt;
        private void IDWiseMedicine_Load(object sender, EventArgs e)
        {
            string constr = @" Data Source =RISHABH\SQLEXPRESS; Initial Catalog=MedicalShop;integrated Security=sspi";
            objcon = new SqlConnection(constr);
            label1.Visible = false;
            cmbmedicineid.Visible = false;
        }

        private void cmbmedicineid_Click(object sender, EventArgs e)
        {
            cmbmedicineid.Items.Clear();
            objadapt = new SqlDataAdapter("Select * from Medicine", objcon);
            objdt = new DataTable();
            objadapt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbmedicineid.Items.Add(dr["MedicineId"].ToString());
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (rbtnviewall.Checked == true)
            {
                objadapt = new SqlDataAdapter("Select * from Medicine", objcon);
            }
            else
            {
                if (rbtnidwise.Checked == true)
                {
                    objadapt = new SqlDataAdapter("Select * from Medicine where MedicineId='" + cmbmedicineid.Text + "'", objcon);
                }
            }
            objdt = new DataTable();
            objadapt.Fill(objdt);
            dataGridView1.DataSource = objdt;
        }

        private void rbtnidwise_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            cmbmedicineid.Visible = true;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
