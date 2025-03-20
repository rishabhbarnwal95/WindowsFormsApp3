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
    public partial class NameWiseMedicine : Form
    {
        public NameWiseMedicine()
        {
            InitializeComponent();
        }
        SqlConnection objcon;
        SqlDataAdapter objadapt;
        DataTable objdt;
        private void NameWiseMedicine_Load(object sender, EventArgs e)
        {
            String constr;
            constr = @"Data Source=RISHABH\SQLEXPRESS; Initial Catalog=MedicalShop; Integrated Security=sspi";
            objcon = new SqlConnection(constr);
            label1.Visible = false;
            cmbmedicinename.Visible = false;
        }

        private void rbtnidwise_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            cmbmedicinename.Visible = true;
        }

        private void cmbmedicinename_Click(object sender, EventArgs e)
        {
            cmbmedicinename.Items.Clear();
            objadapt = new SqlDataAdapter("Select * from Medicine", objcon);
            objdt = new DataTable();
            objadapt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbmedicinename.Items.Add(dr["MedicineName"].ToString());
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
                    objadapt = new SqlDataAdapter("Select * from Medicine where MedicineName='" + cmbmedicinename.Text + "'", objcon);
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
