namespace ayman_restaurant
{
    partial class frbilladd
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgvitem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvbill = new System.Windows.Forms.DataGridView();
            this.dgvno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvitems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvprices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvadd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvdelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btncancebill = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.dgvcat = new System.Windows.Forms.DataGridView();
            this.dgvcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.clo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 23);
            this.panel1.TabIndex = 0;
            // 
            // clo
            // 
            this.clo.BackColor = System.Drawing.Color.Red;
            this.clo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clo.FlatAppearance.BorderSize = 0;
            this.clo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clo.Location = new System.Drawing.Point(836, 0);
            this.clo.Name = "clo";
            this.clo.Size = new System.Drawing.Size(29, 23);
            this.clo.TabIndex = 14;
            this.clo.Text = "X";
            this.clo.UseVisualStyleBackColor = false;
            this.clo.Click += new System.EventHandler(this.clo_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvitem,
            this.dgvprice});
            this.dgv.Location = new System.Drawing.Point(583, 29);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(195, 411);
            this.dgv.TabIndex = 2;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvitemandprice_CellContentClick);
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvitemandprice_CellDoubleClick);
            // 
            // dgvitem
            // 
            this.dgvitem.HeaderText = "الصنف";
            this.dgvitem.Name = "dgvitem";
            this.dgvitem.ReadOnly = true;
            this.dgvitem.Width = 110;
            // 
            // dgvprice
            // 
            this.dgvprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvprice.HeaderText = "السعر";
            this.dgvprice.Name = "dgvprice";
            this.dgvprice.ReadOnly = true;
            // 
            // dgvbill
            // 
            this.dgvbill.AllowUserToAddRows = false;
            this.dgvbill.AllowUserToDeleteRows = false;
            this.dgvbill.BackgroundColor = System.Drawing.Color.White;
            this.dgvbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvno,
            this.dgvitems,
            this.dgvnumber,
            this.dgvprices,
            this.dgvtotal,
            this.dgvadd,
            this.dgvdelete});
            this.dgvbill.Location = new System.Drawing.Point(134, 29);
            this.dgvbill.Name = "dgvbill";
            this.dgvbill.ReadOnly = true;
            this.dgvbill.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvbill.RowHeadersVisible = false;
            this.dgvbill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbill.Size = new System.Drawing.Size(448, 384);
            this.dgvbill.TabIndex = 3;
            this.dgvbill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbill_CellClick);
            this.dgvbill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbill_CellContentClick);
            this.dgvbill.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbill_CellDoubleClick);
            // 
            // dgvno
            // 
            this.dgvno.HeaderText = "الرقم";
            this.dgvno.Name = "dgvno";
            this.dgvno.ReadOnly = true;
            this.dgvno.Width = 40;
            // 
            // dgvitems
            // 
            this.dgvitems.HeaderText = "المنتج";
            this.dgvitems.Name = "dgvitems";
            this.dgvitems.ReadOnly = true;
            this.dgvitems.Width = 110;
            // 
            // dgvnumber
            // 
            this.dgvnumber.HeaderText = "العدد";
            this.dgvnumber.Name = "dgvnumber";
            this.dgvnumber.ReadOnly = true;
            this.dgvnumber.Width = 40;
            // 
            // dgvprices
            // 
            this.dgvprices.HeaderText = "سعر الحبة";
            this.dgvprices.Name = "dgvprices";
            this.dgvprices.ReadOnly = true;
            this.dgvprices.Width = 80;
            // 
            // dgvtotal
            // 
            this.dgvtotal.HeaderText = "المجموع";
            this.dgvtotal.Name = "dgvtotal";
            this.dgvtotal.ReadOnly = true;
            this.dgvtotal.Width = 75;
            // 
            // dgvadd
            // 
            this.dgvadd.HeaderText = "اضافة";
            this.dgvadd.Name = "dgvadd";
            this.dgvadd.ReadOnly = true;
            this.dgvadd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvadd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvadd.Text = "+";
            this.dgvadd.UseColumnTextForButtonValue = true;
            this.dgvadd.Width = 50;
            // 
            // dgvdelete
            // 
            this.dgvdelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvdelete.HeaderText = "حذف";
            this.dgvdelete.Name = "dgvdelete";
            this.dgvdelete.ReadOnly = true;
            this.dgvdelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvdelete.Text = "-";
            this.dgvdelete.UseColumnTextForButtonValue = true;
            this.dgvdelete.Width = 50;
            // 
            // btncancebill
            // 
            this.btncancebill.BackgroundImage = global::ayman_restaurant.Properties.Resources.ال;
            this.btncancebill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancebill.FlatAppearance.BorderSize = 0;
            this.btncancebill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancebill.Location = new System.Drawing.Point(17, 47);
            this.btncancebill.Name = "btncancebill";
            this.btncancebill.Size = new System.Drawing.Size(101, 23);
            this.btncancebill.TabIndex = 4;
            this.btncancebill.Text = "الغاء فاتورة البيع";
            this.btncancebill.UseVisualStyleBackColor = true;
            this.btncancebill.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackgroundImage = global::ayman_restaurant.Properties.Resources.الال;
            this.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Location = new System.Drawing.Point(17, 401);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(101, 23);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "حفظ";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvcat
            // 
            this.dgvcat.AllowUserToAddRows = false;
            this.dgvcat.AllowUserToDeleteRows = false;
            this.dgvcat.BackgroundColor = System.Drawing.Color.White;
            this.dgvcat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcategory});
            this.dgvcat.Location = new System.Drawing.Point(778, 29);
            this.dgvcat.Name = "dgvcat";
            this.dgvcat.ReadOnly = true;
            this.dgvcat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvcat.RowHeadersVisible = false;
            this.dgvcat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcat.Size = new System.Drawing.Size(83, 411);
            this.dgvcat.TabIndex = 6;
            this.dgvcat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dgvcategory
            // 
            this.dgvcategory.HeaderText = "القسم";
            this.dgvcategory.Name = "dgvcategory";
            this.dgvcategory.ReadOnly = true;
            this.dgvcategory.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(68, 214);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "المجموع :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(17, 230);
            this.textBox3.Name = "textBox3";
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox3.Size = new System.Drawing.Size(101, 20);
            this.textBox3.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 420);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 335);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(101, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(80, 253);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "الخصم:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(68, 282);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton1.Size = new System.Drawing.Size(45, 17);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "مبلغ";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(63, 305);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "نسبة";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // frbilladd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(865, 445);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvcat);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btncancebill);
            this.Controls.Add(this.dgvbill);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frbilladd";
            this.Text = "frbilladd";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clo;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridView dgvbill;
        private System.Windows.Forms.Button btncancebill;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView dgvcat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvitems;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvprices;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtotal;
        private System.Windows.Forms.DataGridViewButtonColumn dgvadd;
        private System.Windows.Forms.DataGridViewButtonColumn dgvdelete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}