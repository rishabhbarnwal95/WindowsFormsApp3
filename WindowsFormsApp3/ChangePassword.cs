using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        SqlConnection objcon;
        SqlCommand objcomm;
        SqlDataAdapter objadapt;
        DataTable objdt;
        string password;

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            string constr= @"Data Source=RISHABH\SQLEXPRESS; initial catalog=MedicalShop;integrated security=sspi";
            objcon = new SqlConnection(constr);
            objadapt = new SqlDataAdapter("Select password from login where username='" + txtusername.Text + "'", objcon);
            objdt = new DataTable();
            objadapt.Fill(objdt);
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
          

            password = txtoldpassword.Text;
            foreach(DataRow dr in objdt.Rows)
            {
                
            }
            if (password == txtoldpassword.Text)
            {
                if (txtnewpassword.Text == txtconfirmpassword.Text)
                {
                    objcomm = new SqlCommand("Update login set Password='" + txtnewpassword.Text + "' where password='" + txtoldpassword.Text + "' and username='"+txtusername.Text+"'", objcon);
                    objcon.Open();
                    objcomm.ExecuteNonQuery();
                    objcon.Close();
                    MessageBox.Show("Password updated...");
                }
                else
                {
                    MessageBox.Show ( "Your password does not match");
                    txtconfirmpassword.Focus();
                }

            }
            else
            {
                MessageBox.Show("Your password doesn't match with database");
                txtoldpassword.Focus();
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            txtoldpassword.Text = objdt.ToString();

        }
    }
}
