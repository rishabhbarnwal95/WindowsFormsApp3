namespace WindowsFormsApp3
{
    partial class VoucharSale
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
            this.btncancel = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbvoucharnumber = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnidwise = new System.Windows.Forms.RadioButton();
            this.rbtnviewall = new System.Windows.Forms.RadioButton();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Controls.Add(this.btncancel);
            this.groupBox3.Controls.Add(this.btnshow);
            this.groupBox3.Location = new System.Drawing.Point(12, 381);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(589, 57);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(480, 18);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(85, 29);
            this.btncancel.TabIndex = 1;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnshow
            // 
            this.btnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(369, 18);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(87, 29);
            this.btnshow.TabIndex = 0;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.cmbvoucharnumber);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 304);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(17, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(546, 237);
            this.dataGridView1.TabIndex = 2;
            // 
            // cmbvoucharnumber
            // 
            this.cmbvoucharnumber.FormattingEnabled = true;
            this.cmbvoucharnumber.Location = new System.Drawing.Point(167, 15);
            this.cmbvoucharnumber.Name = "cmbvoucharnumber";
            this.cmbvoucharnumber.Size = new System.Drawing.Size(136, 24);
            this.cmbvoucharnumber.TabIndex = 1;
            this.cmbvoucharnumber.Click += new System.EventHandler(this.cmbvoucharnumber_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vouchar Number";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.rbtnidwise);
            this.groupBox1.Controls.Add(this.rbtnviewall);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 56);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // rbtnidwise
            // 
            this.rbtnidwise.AutoSize = true;
            this.rbtnidwise.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnidwise.Location = new System.Drawing.Point(167, 21);
            this.rbtnidwise.Name = "rbtnidwise";
            this.rbtnidwise.Size = new System.Drawing.Size(82, 20);
            this.rbtnidwise.TabIndex = 1;
            this.rbtnidwise.TabStop = true;
            this.rbtnidwise.Text = "ID Wise";
            this.rbtnidwise.UseVisualStyleBackColor = true;
            this.rbtnidwise.CheckedChanged += new System.EventHandler(this.rbtnidwise_CheckedChanged);
            // 
            // rbtnviewall
            // 
            this.rbtnviewall.AutoSize = true;
            this.rbtnviewall.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnviewall.Location = new System.Drawing.Point(17, 21);
            this.rbtnviewall.Name = "rbtnviewall";
            this.rbtnviewall.Size = new System.Drawing.Size(83, 20);
            this.rbtnviewall.TabIndex = 0;
            this.rbtnviewall.TabStop = true;
            this.rbtnviewall.Text = "View All";
            this.rbtnviewall.UseVisualStyleBackColor = true;
            // 
            // VoucharSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VoucharSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VoucharSale";
            this.Load += new System.EventHandler(this.VoucharSale_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbvoucharnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnidwise;
        private System.Windows.Forms.RadioButton rbtnviewall;
    }
}