namespace WindowsFormsApp3
{
    partial class Employee
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
            this.dtpjoiningdate = new System.Windows.Forms.DateTimePicker();
            this.cmbemployeeid = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtemployeeid = new System.Windows.Forms.TextBox();
            this.txtemployeename = new System.Windows.Forms.TextBox();
            this.txtdesignation = new System.Windows.Forms.TextBox();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btmcancel = new System.Windows.Forms.Button();
            this.btmsave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.dtpjoiningdate);
            this.groupBox2.Controls.Add(this.cmbemployeeid);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtaddress);
            this.groupBox2.Controls.Add(this.txtemployeeid);
            this.groupBox2.Controls.Add(this.txtemployeename);
            this.groupBox2.Controls.Add(this.txtdesignation);
            this.groupBox2.Controls.Add(this.txtsalary);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 285);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // dtpjoiningdate
            // 
            this.dtpjoiningdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpjoiningdate.Location = new System.Drawing.Point(177, 94);
            this.dtpjoiningdate.Name = "dtpjoiningdate";
            this.dtpjoiningdate.Size = new System.Drawing.Size(189, 22);
            this.dtpjoiningdate.TabIndex = 15;
            // 
            // cmbemployeeid
            // 
            this.cmbemployeeid.FormattingEnabled = true;
            this.cmbemployeeid.Location = new System.Drawing.Point(177, 16);
            this.cmbemployeeid.Name = "cmbemployeeid";
            this.cmbemployeeid.Size = new System.Drawing.Size(189, 24);
            this.cmbemployeeid.TabIndex = 14;
            this.cmbemployeeid.SelectedIndexChanged += new System.EventHandler(this.cmbemployeeid_SelectedIndexChanged);
            this.cmbemployeeid.Click += new System.EventHandler(this.cmbemployeeid_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Address";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(177, 209);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(189, 22);
            this.txtaddress.TabIndex = 12;
            // 
            // txtemployeeid
            // 
            this.txtemployeeid.Location = new System.Drawing.Point(177, 18);
            this.txtemployeeid.Name = "txtemployeeid";
            this.txtemployeeid.Size = new System.Drawing.Size(189, 22);
            this.txtemployeeid.TabIndex = 11;
            // 
            // txtemployeename
            // 
            this.txtemployeename.Location = new System.Drawing.Point(177, 56);
            this.txtemployeename.Name = "txtemployeename";
            this.txtemployeename.Size = new System.Drawing.Size(189, 22);
            this.txtemployeename.TabIndex = 10;
            // 
            // txtdesignation
            // 
            this.txtdesignation.Location = new System.Drawing.Point(177, 171);
            this.txtdesignation.Name = "txtdesignation";
            this.txtdesignation.Size = new System.Drawing.Size(189, 22);
            this.txtdesignation.TabIndex = 9;
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(177, 134);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(189, 22);
            this.txtsalary.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Designation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Joining Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Controls.Add(this.btmcancel);
            this.groupBox3.Controls.Add(this.btmsave);
            this.groupBox3.Location = new System.Drawing.Point(13, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 71);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // btmcancel
            // 
            this.btmcancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmcancel.Location = new System.Drawing.Point(245, 21);
            this.btmcancel.Name = "btmcancel";
            this.btmcancel.Size = new System.Drawing.Size(120, 31);
            this.btmcancel.TabIndex = 1;
            this.btmcancel.Text = "CANCEL";
            this.btmcancel.UseVisualStyleBackColor = true;
            this.btmcancel.Click += new System.EventHandler(this.btmcancel_Click);
            // 
            // btmsave
            // 
            this.btmsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmsave.Location = new System.Drawing.Point(98, 21);
            this.btmsave.Name = "btmsave";
            this.btmsave.Size = new System.Drawing.Size(120, 31);
            this.btmsave.TabIndex = 0;
            this.btmsave.Text = "SAVE";
            this.btmsave.UseVisualStyleBackColor = true;
            this.btmsave.Click += new System.EventHandler(this.btmsave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 61);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(265, 18);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(101, 29);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(143, 18);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(96, 29);
            this.btnupdate.TabIndex = 1;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(21, 18);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(94, 29);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpjoiningdate;
        private System.Windows.Forms.ComboBox cmbemployeeid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtemployeeid;
        private System.Windows.Forms.TextBox txtemployeename;
        private System.Windows.Forms.TextBox txtdesignation;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btmcancel;
        private System.Windows.Forms.Button btmsave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
    }
}