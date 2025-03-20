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
    public partial class DateWisePurchase : Form
    {
        public DateWisePurchase()
        {
            InitializeComponent();
        }
        SqlConnection objcon;
        SqlDataAdapter objadapt;
        DataTable objdt;
        SqlCommand objcomm;
        private void DateWisePurchase_Load(object sender, EventArgs e)
        {
            string constr = @"Data Source=RISHABH\SQLEXPRESS; Initial Catalog=MedicalShop; Integrated Security=sspi";
            objcon = new SqlConnection(constr);
            label1.Visible = false;
            label2.Visible = false;
            dtpfromdate.Visible = false;
            dtptodate.Visible = false;
        }

        private void rbtndatewise_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            dtpfromdate.Visible = true;
            dtptodate.Visible = true;
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (rbtnviewall.Checked)
            {
                objadapt = new SqlDataAdapter("select * from Purchase", objcon);
            }
            else
            {
                if (rbtndatewise.Checked)
                {
                    objadapt = new SqlDataAdapter("select * from Purchase where Voucherdate>='" + dtpfromdate.Text + "' and Voucherdate<='" + dtptodate.Text + "'", objcon);
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
