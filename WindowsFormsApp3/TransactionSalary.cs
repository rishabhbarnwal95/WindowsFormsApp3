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
    public partial class TransactionSalary : Form
    {
        public TransactionSalary()
        {
            InitializeComponent();
        }
        SqlConnection objcon;
        SqlDataAdapter objadapt;
        DataTable objdt;
        SqlCommand objcomm;
        private void TransactionSalary_Load(object sender, EventArgs e)
        {
            String constr = @"data source=RISHABH\SQLEXPRESS;initial catalog=MedicalShop;integrated security=sspi";
            objcon = new SqlConnection(constr);
        }

        private void cmbemployeeid_Click(object sender, EventArgs e)
        {
            cmbemployeeid.Items.Clear();
            objadapt = new SqlDataAdapter("Select * from employee", objcon);
            objdt = new DataTable();
            objadapt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbemployeeid.Items.Add(dr["EmployeeID"].ToString());
            }
        }

        private void cmbemployeeid_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtname.Text = objdt.Rows[cmbemployeeid.SelectedIndex]["employeeName"].ToString();
            txtbasicsalary.Text = objdt.Rows[cmbemployeeid.SelectedIndex]["Salary"].ToString();
        }

        private void txtdeduction_TextChanged(object sender, EventArgs e)
        {
            int leave;
            leave = Convert.ToInt32(txtbasicsalary.Text) / 30 * Convert.ToInt32(txtnumofleave.Text);
            txtnetpay.Text = Convert.ToString(Convert.ToInt32(txtbasicsalary.Text) + Convert.ToInt32(txtallowance.Text) - Convert.ToInt32(txtdeduction.Text));
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            objcomm = new SqlCommand("Insert into Salary(EmployeeID,Leave,DateofSalary,Deduction,Allowance,NetSalary)values('" + cmbemployeeid.Text + "','" + txtnumofleave.Text + "','" + dtpsalarydate.Text + "','" + txtdeduction.Text + "','" + txtallowance + "','" + txtnetpay.Text + "')", objcon);
            objcon.Open();
            objcomm.ExecuteNonQuery();
            objcon.Close();
            MessageBox.Show("One row inserted");
            cmbemployeeid.Text = "";
            txtallowance.Text = "0";
            txtname.Text = "";
            txtnumofleave.Text = "0";
            txtnetpay.Text = "";
            txtbasicsalary.Text = "0";
            txtdeduction.Text = "0";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
