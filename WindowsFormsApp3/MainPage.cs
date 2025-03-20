using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            cust.Show();
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company com = new Company();
            com.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            sup.Show();
        }

        private void medicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medicine med = new Medicine();
            med.Show();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionSale s = new TransactionSale();
            s.Show();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionPurchase pur = new TransactionPurchase();
            pur.Show();
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionSalary sala = new TransactionSalary();
            sala.Show();
        }

        private void companyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IDWiseCompany com = new IDWiseCompany();
            com.Show();
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IDWiseCustomer cust = new IDWiseCustomer();
            cust.Show();
        }

        private void employeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IDWiseEmployee emp = new IDWiseEmployee();
            emp.Show();
        }

        private void medicineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IDWiseMedicine med = new IDWiseMedicine();
            med.Show();
        }

        private void supplierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IDWiseSupplier sup = new IDWiseSupplier();
            sup.Show();
        }

        private void companyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            NameWiseCompany com = new NameWiseCompany();
            com.Show();
        }

        private void customerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            NameWiseCustomer cust = new NameWiseCustomer();
            cust.Show();
        }

        private void employeeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            NameWiseEmployee Emp = new NameWiseEmployee();
            Emp.Show();
        }

        private void medicineToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            NameWiseMedicine med = new NameWiseMedicine();
            med.Show();
        }

        private void supplierToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            NameWiseSupplier sup = new NameWiseSupplier();
            sup.Show();
        }

        private void puchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VoucharPurchase pur = new VoucharPurchase();
            pur.Show();
        }

        private void saleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VoucharSale s = new VoucharSale();
            s.Show();
        }

        private void medicineToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DateWiseMedicine med = new DateWiseMedicine();
            med.Show();
        }

        private void purchaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DateWisePurchase pur = new DateWisePurchase();
            pur.Show();
        }

        private void salaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DateWiseSalary sala = new DateWiseSalary();
            sala.Show();
        }

        private void saleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DateWiseSale s = new DateWiseSale();
            s.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "calc.exe";
            p.Start();

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword chp = new ChangePassword();
            chp.Show();
        }

        private void keyboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process k = new Process();
            k.StartInfo.FileName = @"C:\Users\risha\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Accessibility\FreeVK.exe";
            k.Start();
          //  Process.Start(Application.StartupPath + @"\FreeVK.exe");

        }
    }
}
