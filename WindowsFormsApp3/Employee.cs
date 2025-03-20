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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        SqlConnection objcon;
        SqlCommand objcomm;
        SqlDataAdapter objadapt;
        DataTable objdt;
        private void Employee_Load(object sender, EventArgs e)
        {
            string constr;
            constr = @"data source=RISHABH\SQLEXPRESS;initial catalog=MedicalShop;integrated security=sspi";
            objcon = new SqlConnection(constr);
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            cmbemployeeid.Visible = false;
        }
        string mode;

        private void btnadd_Click(object sender, EventArgs e)
        {
            mode = "Add";
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            txtemployeeid.Visible = true;
            cmbemployeeid.Visible = false;
            txtemployeename.Visible = true;
            txtdesignation.Visible = true;
            txtaddress.Visible = true;
            txtsalary.Visible = true;
            dtpjoiningdate.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            txtemployeeid.Text = "";
            txtemployeename.Text = "";
            dtpjoiningdate.Text = "";
            txtdesignation.Text = "";
            txtaddress.Text = "";
            txtsalary.Text = "";
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            mode = "Update";
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            txtemployeeid.Visible = false;
            cmbemployeeid.Visible = true;
            txtemployeename.Visible = true;
            txtdesignation.Visible = true;
            txtaddress.Visible = true;
            txtsalary.Visible = true;
            dtpjoiningdate.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            cmbemployeeid.Text = "";
            txtemployeename.Text = "";
            dtpjoiningdate.Text = "";
            txtdesignation.Text = "";
            txtaddress.Text = "";
            txtsalary.Text = "";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            mode = "Delete";
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            txtemployeeid.Visible = false;
            cmbemployeeid.Visible = true;
            txtemployeename.Visible = true;
            dtpjoiningdate.Visible = false;
            txtdesignation.Visible = false;
            txtaddress.Visible = false;
            txtsalary.Visible = false;
            dtpjoiningdate.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            cmbemployeeid.Text = "";
            txtemployeename.Text = "";
        }

        private void cmbemployeeid_Click(object sender, EventArgs e)
        {
            cmbemployeeid.Items.Clear();
            objadapt = new SqlDataAdapter("Select * from Employee ", objcon);
            objdt = new DataTable();
            objadapt.Fill(objdt);
            foreach (DataRow dr in objdt.Rows)
            {
                cmbemployeeid.Items.Add(dr["EmployeeID"].ToString());
            }
        }

        private void btmsave_Click(object sender, EventArgs e)
        {
            if (mode == "Add")
            {
                objadapt = new SqlDataAdapter("Select * from Employee where EmployeeID='" + txtemployeeid.Text + "'", objcon);
                objdt = new DataTable();
                objadapt.Fill(objdt);
                if (objdt.Rows.Count > 0)
                {
                    MessageBox.Show("Employee ID already exist...");
                    txtemployeeid.Text = "";
                    txtemployeeid.Focus();
                }
                if (txtemployeeid.Text == "")
                {
                    MessageBox.Show("Enter the Employee ID...");
                    txtemployeeid.Focus();
                }
                if (txtemployeename.Text == "")
                {
                    MessageBox.Show("Enter the Employee Name...");
                    txtemployeename.Focus();
                }
                /* if (dtpjoiningdate.Text == "")
                   {
                       MessageBox.Show("Enter the Joining Date...");
                       cmbcompanyid.Focus();
                   }*/
                if (txtsalary.Text == "")
                {
                    MessageBox.Show("Enter the Salary...");
                    txtsalary.Focus();
                }
                if (txtdesignation.Text == "")
                {
                    MessageBox.Show("Enter the Designation...");
                    txtdesignation.Focus();
                }
                if (txtaddress.Text == "")
                {
                    MessageBox.Show("Enter the Address...");
                    txtaddress.Focus();
                }

                else
                {
                    objcomm = new SqlCommand("insert into Employee(EmployeeID,EmployeeName,JoiningDate,Salary,Designation,Address)values('" + txtemployeeid.Text + "','" + txtemployeename.Text + "','" + dtpjoiningdate.Text + "','" + txtsalary.Text + "','" + txtdesignation.Text + "','" + txtaddress.Text + "')", objcon);
                    objcon.Open();
                    objcomm.ExecuteNonQuery();
                    objcon.Close();
                    MessageBox.Show("One Row Inserted..");
                    txtemployeeid.Text = "";
                    txtemployeename.Text = "";

                    txtsalary.Text = "";
                    //txtpower.Text = "";
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;
                }
            }
            if (mode == "Update")
            {
                objcomm = new SqlCommand("update Employee set EmployeeName='" + txtemployeename.Text + "',JoiningDate='" + dtpjoiningdate.Text + "',Salary='" + txtsalary.Text + "',Designation='" + txtdesignation.Text + "' where EmployeeId='" + cmbemployeeid + "'", objcon);
                objcon.Open();
                objcomm.ExecuteNonQuery();
                objcon.Close();
                MessageBox.Show("One Row Updated..");
                /* cmbcompanyid.Text = "";
                 txtmedicinename.Text = "";
                 txtmedicinecode.Text = "";
                 txtprice.Text = "";
                 txtpower.Text = ""; */
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;


            }
            if (mode == "Delete")
            {
                objcomm = new SqlCommand("delete from Employee where Employee='" + cmbemployeeid.Text + "'", objcon);
                objcon.Open();
                objcomm.ExecuteNonQuery();
                MessageBox.Show("One Record Deleted..");
                objcon.Close();
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                /* txtmedicinename.Text = "";
                 cmbcompanyid.Text = "";
                 txtmedicinecode.Text = "";
                 txtpower.Text = "";
                 txtprice.Text = "";
                 cmbmedicinecode.Text = ""; */
            }
        }

        private void cmbemployeeid_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtemployeename.Text = objdt.Rows[cmbemployeeid.SelectedIndex]["EmployeeName"].ToString();
            dtpjoiningdate.Text = objdt.Rows[cmbemployeeid.SelectedIndex]["JoiningDate"].ToString();
            txtsalary.Text = objdt.Rows[cmbemployeeid.SelectedIndex]["Salary"].ToString();
            txtdesignation.Text = objdt.Rows[cmbemployeeid.SelectedIndex]["Designation"].ToString();
            txtaddress.Text = objdt.Rows[cmbemployeeid.SelectedIndex]["Address"].ToString();
        }

        private void btmcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
