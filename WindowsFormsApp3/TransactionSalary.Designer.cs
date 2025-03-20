namespace WindowsFormsApp3
{
    partial class TransactionSalary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbemployeeid = new System.Windows.Forms.ComboBox();
            this.dtpsalarydate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbasicsalary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumofleave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnetpay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdeduction = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtallowance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.btnexit);
            this.groupBox2.Controls.Add(this.btninsert);
            this.groupBox2.Location = new System.Drawing.Point(12, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 52);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(198, 17);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(87, 24);
            this.btnexit.TabIndex = 1;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btninsert
            // 
            this.btninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.Location = new System.Drawing.Point(96, 17);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(87, 24);
            this.btninsert.TabIndex = 0;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.cmbemployeeid);
            this.groupBox1.Controls.Add(this.dtpsalarydate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtbasicsalary);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtnumofleave);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtnetpay);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtdeduction);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtallowance);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 244);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // cmbemployeeid
            // 
            this.cmbemployeeid.FormattingEnabled = true;
            this.cmbemployeeid.Location = new System.Drawing.Point(134, 40);
            this.cmbemployeeid.Name = "cmbemployeeid";
            this.cmbemployeeid.Size = new System.Drawing.Size(151, 24);
            this.cmbemployeeid.TabIndex = 17;
            this.cmbemployeeid.SelectedIndexChanged += new System.EventHandler(this.cmbemployeeid_SelectedIndexChanged);
            this.cmbemployeeid.Click += new System.EventHandler(this.cmbemployeeid_Click);
            // 
            // dtpsalarydate
            // 
            this.dtpsalarydate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpsalarydate.Location = new System.Drawing.Point(133, 14);
            this.dtpsalarydate.Name = "dtpsalarydate";
            this.dtpsalarydate.Size = new System.Drawing.Size(153, 22);
            this.dtpsalarydate.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date of Salary";
            // 
            // txtbasicsalary
            // 
            this.txtbasicsalary.Location = new System.Drawing.Point(133, 97);
            this.txtbasicsalary.Name = "txtbasicsalary";
            this.txtbasicsalary.Size = new System.Drawing.Size(154, 22);
            this.txtbasicsalary.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee ID";
            // 
            // txtnumofleave
            // 
            this.txtnumofleave.Location = new System.Drawing.Point(133, 124);
            this.txtnumofleave.Name = "txtnumofleave";
            this.txtnumofleave.Size = new System.Drawing.Size(154, 22);
            this.txtnumofleave.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(133, 69);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(154, 22);
            this.txtname.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Basic Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "No. of Leave ";
            // 
            // txtnetpay
            // 
            this.txtnetpay.Location = new System.Drawing.Point(133, 208);
            this.txtnetpay.Name = "txtnetpay";
            this.txtnetpay.Size = new System.Drawing.Size(154, 22);
            this.txtnetpay.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Allowance";
            // 
            // txtdeduction
            // 
            this.txtdeduction.Location = new System.Drawing.Point(133, 180);
            this.txtdeduction.Name = "txtdeduction";
            this.txtdeduction.Size = new System.Drawing.Size(154, 22);
            this.txtdeduction.TabIndex = 10;
            this.txtdeduction.TextChanged += new System.EventHandler(this.txtdeduction_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Deduction";
            // 
            // txtallowance
            // 
            this.txtallowance.Location = new System.Drawing.Point(133, 152);
            this.txtallowance.Name = "txtallowance";
            this.txtallowance.Size = new System.Drawing.Size(154, 22);
            this.txtallowance.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Net Pay";
            // 
            // TransactionSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 324);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TransactionSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransactionSalary";
            this.Load += new System.EventHandler(this.TransactionSalary_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbemployeeid;
        private System.Windows.Forms.DateTimePicker dtpsalarydate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbasicsalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumofleave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnetpay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdeduction;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtallowance;
        private System.Windows.Forms.Label label8;
    }
}