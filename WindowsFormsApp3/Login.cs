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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection objcon;
        private void Login_Load(object sender, EventArgs e)
        {
            string constr = @"Data source=RISHABH\SQLEXPRESS;initial catalog=MedicalShop;integrated security=sspi";
            objcon = new SqlConnection(constr);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlDataAdapter objadapt = new SqlDataAdapter("select * from login where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "' ", objcon);
            DataTable objdt = new DataTable();
            objadapt.Fill(objdt);
            if (objdt.Rows.Count > 0)
            {
                MainPage objmainpg = new MainPage();
                objmainpg.Show();

            }
            else if (txtusername.Text == "")
            {
                MessageBox.Show("Enter User Name");
            }
            else
            {
                MessageBox.Show("Invalid User");
                txtusername.Text = "";
                txtpassword.Text = "";
                txtusername.Focus();
            }
        }
    }
}
