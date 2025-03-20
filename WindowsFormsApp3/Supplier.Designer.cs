namespace WindowsFormsApp3
{
    partial class Supplier
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btmcancel = new System.Windows.Forms.Button();
            this.btmsave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbmedicinecode = new System.Windows.Forms.ComboBox();
            this.cmbcompanyid = new System.Windows.Forms.ComboBox();
            this.cmbsupplierid = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsuppliername = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtsupplierid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Controls.Add(this.btmcancel);
            this.groupBox3.Controls.Add(this.btmsave);
            this.groupBox3.Location = new System.Drawing.Point(12, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 71);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // btmcancel
            // 
            this.btmcancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmcancel.Location = new System.Drawing.Point(246, 21);
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
            this.btmsave.Location = new System.Drawing.Point(100, 21);
            this.btmsave.Name = "btmsave";
            this.btmsave.Size = new System.Drawing.Size(120, 31);
            this.btmsave.TabIndex = 0;
            this.btmsave.Text = "SAVE";
            this.btmsave.UseVisualStyleBackColor = true;
            this.btmsave.Click += new System.EventHandler(this.btmsave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.cmbmedicinecode);
            this.groupBox2.Controls.Add(this.cmbcompanyid);
            this.groupBox2.Controls.Add(this.cmbsupplierid);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtemail);
            this.groupBox2.Controls.Add(this.txtsuppliername);
            this.groupBox2.Controls.Add(this.txtphone);
            this.groupBox2.Controls.Add(this.txtaddress);
            this.groupBox2.Controls.Add(this.txtsupplierid);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 285);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // cmbmedicinecode
            // 
            this.cmbmedicinecode.FormattingEnabled = true;
            this.cmbmedicinecode.Location = new System.Drawing.Point(177, 133);
            this.cmbmedicinecode.Name = "cmbmedicinecode";
            this.cmbmedicinecode.Size = new System.Drawing.Size(190, 24);
            this.cmbmedicinecode.TabIndex = 16;
            this.cmbmedicinecode.Click += new System.EventHandler(this.cmbmedicinecode_Click);
            // 
            // cmbcompanyid
            // 
            this.cmbcompanyid.FormattingEnabled = true;
            this.cmbcompanyid.Location = new System.Drawing.Point(176, 94);
            this.cmbcompanyid.Name = "cmbcompanyid";
            this.cmbcompanyid.Size = new System.Drawing.Size(190, 24);
            this.cmbcompanyid.TabIndex = 15;
            this.cmbcompanyid.Click += new System.EventHandler(this.cmbcompanyid_Click);
            // 
            // cmbsupplierid
            // 
            this.cmbsupplierid.FormattingEnabled = true;
            this.cmbsupplierid.Location = new System.Drawing.Point(177, 13);
            this.cmbsupplierid.Name = "cmbsupplierid";
            this.cmbsupplierid.Size = new System.Drawing.Size(189, 24);
            this.cmbsupplierid.TabIndex = 14;
            this.cmbsupplierid.SelectedIndexChanged += new System.EventHandler(this.cmbsupplierid_SelectedIndexChanged);
            this.cmbsupplierid.Click += new System.EventHandler(this.cmbsupplierid_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(177, 248);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(189, 22);
            this.txtemail.TabIndex = 12;
            // 
            // txtsuppliername
            // 
            this.txtsuppliername.Location = new System.Drawing.Point(177, 56);
            this.txtsuppliername.Name = "txtsuppliername";
            this.txtsuppliername.Size = new System.Drawing.Size(189, 22);
            this.txtsuppliername.TabIndex = 10;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(177, 208);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(189, 22);
            this.txtphone.TabIndex = 9;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(177, 171);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(189, 22);
            this.txtaddress.TabIndex = 8;
            // 
            // txtsupplierid
            // 
            this.txtsupplierid.Location = new System.Drawing.Point(177, 14);
            this.txtsupplierid.Name = "txtsupplierid";
            this.txtsupplierid.Size = new System.Drawing.Size(189, 22);
            this.txtsupplierid.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Medicine Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Company ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier ID";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 61);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(266, 18);
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
            this.btnupdate.Location = new System.Drawing.Point(150, 18);
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
            this.btnadd.Location = new System.Drawing.Point(34, 18);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(94, 29);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 449);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btmcancel;
        private System.Windows.Forms.Button btmsave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbmedicinecode;
        private System.Windows.Forms.ComboBox cmbcompanyid;
        private System.Windows.Forms.ComboBox cmbsupplierid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtsuppliername;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtsupplierid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
    }
}