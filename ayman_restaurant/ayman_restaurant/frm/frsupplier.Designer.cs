namespace ayman_restaurant
{
    partial class frsupplier
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.clo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxphon = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvs_name_company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvs_phon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvs_fex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxname = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxfex = new System.Windows.Forms.TextBox();
            this.tbxnamead = new System.Windows.Forms.TextBox();
            this.tbxaddress = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 22);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // clo
            // 
            this.clo.BackColor = System.Drawing.Color.Red;
            this.clo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.clo.FlatAppearance.BorderSize = 2;
            this.clo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clo.Location = new System.Drawing.Point(770, 0);
            this.clo.Name = "clo";
            this.clo.Size = new System.Drawing.Size(30, 22);
            this.clo.TabIndex = 14;
            this.clo.Text = "X";
            this.clo.UseVisualStyleBackColor = false;
            this.clo.Click += new System.EventHandler(this.clo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "رقم الهاتف";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "اسم الشركة اوالمتجر";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(636, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "العنوان";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(627, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "اسم المزود";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxphon
            // 
            this.tbxphon.Location = new System.Drawing.Point(57, 24);
            this.tbxphon.Name = "tbxphon";
            this.tbxphon.Size = new System.Drawing.Size(167, 20);
            this.tbxphon.TabIndex = 2;
            this.tbxphon.TextChanged += new System.EventHandler(this.tbxphon_TextChanged);
            // 
            // btnsave
            // 
            this.btnsave.BackgroundImage = global::ayman_restaurant.Properties.Resources.ال;
            this.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Location = new System.Drawing.Point(197, 105);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 23);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "حفظ";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::ayman_restaurant.Properties.Resources.rr;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(9, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "حذف";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::ayman_restaurant.Properties.Resources.tnt;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(111, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "تعديل";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ayman_restaurant.Properties.Resources.tt;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(213, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "اضافة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(239, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 64);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvid,
            this.dgv_name,
            this.dgvs_name_company,
            this.dgv_address,
            this.dgvs_phon,
            this.dgvs_fex});
            this.dgv.Location = new System.Drawing.Point(6, 14);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(760, 157);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // dgvid
            // 
            this.dgvid.HeaderText = "الرقم";
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            this.dgvid.Visible = false;
            // 
            // dgv_name
            // 
            this.dgv_name.HeaderText = "اسم المزود";
            this.dgv_name.Name = "dgv_name";
            this.dgv_name.ReadOnly = true;
            this.dgv_name.Width = 170;
            // 
            // dgvs_name_company
            // 
            this.dgvs_name_company.HeaderText = "اسم الشركة او المتجر";
            this.dgvs_name_company.Name = "dgvs_name_company";
            this.dgvs_name_company.ReadOnly = true;
            this.dgvs_name_company.Width = 170;
            // 
            // dgv_address
            // 
            this.dgv_address.HeaderText = "العنوان";
            this.dgv_address.Name = "dgv_address";
            this.dgv_address.ReadOnly = true;
            this.dgv_address.Width = 170;
            // 
            // dgvs_phon
            // 
            this.dgvs_phon.HeaderText = "رقم الهاتف";
            this.dgvs_phon.Name = "dgvs_phon";
            this.dgvs_phon.ReadOnly = true;
            this.dgvs_phon.Width = 130;
            // 
            // dgvs_fex
            // 
            this.dgvs_fex.HeaderText = "رقم الفاكس";
            this.dgvs_fex.Name = "dgvs_fex";
            this.dgvs_fex.ReadOnly = true;
            this.dgvs_fex.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Location = new System.Drawing.Point(14, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 182);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbxname
            // 
            this.tbxname.Location = new System.Drawing.Point(437, 23);
            this.tbxname.Name = "tbxname";
            this.tbxname.Size = new System.Drawing.Size(167, 20);
            this.tbxname.TabIndex = 1;
            this.tbxname.TextChanged += new System.EventHandler(this.tbxname_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnclear);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbxfex);
            this.groupBox3.Controls.Add(this.tbxnamead);
            this.groupBox3.Controls.Add(this.tbxaddress);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tbxphon);
            this.groupBox3.Controls.Add(this.tbxname);
            this.groupBox3.Controls.Add(this.btnsave);
            this.groupBox3.Location = new System.Drawing.Point(20, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(760, 148);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnclear
            // 
            this.btnclear.BackgroundImage = global::ayman_restaurant.Properties.Resources.الال;
            this.btnclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclear.FlatAppearance.BorderSize = 0;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Location = new System.Drawing.Point(78, 104);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(100, 23);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "الغاء";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "رقم الفاكس";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbxfex
            // 
            this.tbxfex.Location = new System.Drawing.Point(57, 66);
            this.tbxfex.Name = "tbxfex";
            this.tbxfex.Size = new System.Drawing.Size(167, 20);
            this.tbxfex.TabIndex = 12;
            this.tbxfex.TextChanged += new System.EventHandler(this.tbxfex_TextChanged);
            // 
            // tbxnamead
            // 
            this.tbxnamead.Location = new System.Drawing.Point(437, 107);
            this.tbxnamead.Name = "tbxnamead";
            this.tbxnamead.Size = new System.Drawing.Size(167, 20);
            this.tbxnamead.TabIndex = 11;
            this.tbxnamead.TextChanged += new System.EventHandler(this.tbxnamead_TextChanged);
            // 
            // tbxaddress
            // 
            this.tbxaddress.Location = new System.Drawing.Point(437, 67);
            this.tbxaddress.Name = "tbxaddress";
            this.tbxaddress.Size = new System.Drawing.Size(167, 20);
            this.tbxaddress.TabIndex = 10;
            this.tbxaddress.TextChanged += new System.EventHandler(this.tbxaddress_TextChanged);
            // 
            // frsupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.clo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frsupplier";
            this.Text = "frsupplier";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxphon;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxname;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxfex;
        private System.Windows.Forms.TextBox tbxnamead;
        private System.Windows.Forms.TextBox tbxaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvs_name_company;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvs_phon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvs_fex;
        private System.Windows.Forms.Button btnclear;
    }
}