namespace ayman_restaurant
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.clo = new System.Windows.Forms.Button();
            this._log = new System.Windows.Forms.Button();
            this._purchsaing = new System.Windows.Forms.Button();
            this._iteminf = new System.Windows.Forms.Button();
            this._bill = new System.Windows.Forms.Button();
            this.supplier = new System.Windows.Forms.Button();
            this._user = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clo
            // 
            this.clo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clo.BackColor = System.Drawing.Color.Red;
            this.clo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clo.FlatAppearance.BorderSize = 0;
            this.clo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.clo.Location = new System.Drawing.Point(825, 1);
            this.clo.Name = "clo";
            this.clo.Size = new System.Drawing.Size(30, 30);
            this.clo.TabIndex = 13;
            this.clo.Text = "X";
            this.clo.UseVisualStyleBackColor = false;
            this.clo.Click += new System.EventHandler(this.clo_Click);
            // 
            // _log
            // 
            this._log.BackgroundImage = global::ayman_restaurant.Properties.Resources._2221;
            this._log.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._log.FlatAppearance.BorderSize = 0;
            this._log.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this._log.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this._log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._log.Font = new System.Drawing.Font("Technical", 8F);
            this._log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this._log.Location = new System.Drawing.Point(12, 8);
            this._log.Name = "_log";
            this._log.Size = new System.Drawing.Size(101, 23);
            this._log.TabIndex = 19;
            this._log.Text = "تسجيل الدخول";
            this._log.UseVisualStyleBackColor = true;
            this._log.Click += new System.EventHandler(this._log_Click);
            // 
            // _purchsaing
            // 
            this._purchsaing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._purchsaing.AutoSize = true;
            this._purchsaing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_purchsaing.BackgroundImage")));
            this._purchsaing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._purchsaing.FlatAppearance.BorderSize = 0;
            this._purchsaing.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cornsilk;
            this._purchsaing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this._purchsaing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk;
            this._purchsaing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._purchsaing.Font = new System.Drawing.Font("Thick Naskh 2", 12F);
            this._purchsaing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this._purchsaing.Location = new System.Drawing.Point(70, 149);
            this._purchsaing.Name = "_purchsaing";
            this._purchsaing.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._purchsaing.Size = new System.Drawing.Size(237, 68);
            this._purchsaing.TabIndex = 18;
            this._purchsaing.Text = "المشتريات";
            this._purchsaing.UseVisualStyleBackColor = true;
            this._purchsaing.Click += new System.EventHandler(this._purchsaing_Click);
            // 
            // _iteminf
            // 
            this._iteminf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._iteminf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_iteminf.BackgroundImage")));
            this._iteminf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._iteminf.FlatAppearance.BorderSize = 0;
            this._iteminf.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cornsilk;
            this._iteminf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this._iteminf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk;
            this._iteminf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._iteminf.Font = new System.Drawing.Font("Thick Naskh 2", 12F);
            this._iteminf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this._iteminf.Location = new System.Drawing.Point(541, 149);
            this._iteminf.Name = "_iteminf";
            this._iteminf.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._iteminf.Size = new System.Drawing.Size(237, 68);
            this._iteminf.TabIndex = 17;
            this._iteminf.Text = "الوجبات";
            this._iteminf.UseVisualStyleBackColor = true;
            this._iteminf.Click += new System.EventHandler(this._iteminf_Click);
            // 
            // _bill
            // 
            this._bill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._bill.BackColor = System.Drawing.Color.Cornsilk;
            this._bill.BackgroundImage = global::ayman_restaurant.Properties.Resources.Untitled_21;
            this._bill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._bill.FlatAppearance.BorderSize = 0;
            this._bill.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cornsilk;
            this._bill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this._bill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk;
            this._bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._bill.Font = new System.Drawing.Font("Thick Naskh 2", 12F);
            this._bill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this._bill.Location = new System.Drawing.Point(308, 235);
            this._bill.Name = "_bill";
            this._bill.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._bill.Size = new System.Drawing.Size(237, 68);
            this._bill.TabIndex = 16;
            this._bill.Text = "الفواتير";
            this._bill.UseVisualStyleBackColor = false;
            this._bill.Click += new System.EventHandler(this._bill_Click);
            // 
            // supplier
            // 
            this.supplier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.supplier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("supplier.BackgroundImage")));
            this.supplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.supplier.FlatAppearance.BorderSize = 0;
            this.supplier.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cornsilk;
            this.supplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.supplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk;
            this.supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplier.Font = new System.Drawing.Font("Thick Naskh 2", 12F);
            this.supplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.supplier.Location = new System.Drawing.Point(541, 319);
            this.supplier.Name = "supplier";
            this.supplier.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.supplier.Size = new System.Drawing.Size(237, 68);
            this.supplier.TabIndex = 15;
            this.supplier.Text = "المزودين";
            this.supplier.UseVisualStyleBackColor = true;
            this.supplier.Click += new System.EventHandler(this.supplier_Click);
            // 
            // _user
            // 
            this._user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._user.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_user.BackgroundImage")));
            this._user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._user.FlatAppearance.BorderSize = 0;
            this._user.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cornsilk;
            this._user.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this._user.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk;
            this._user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._user.Font = new System.Drawing.Font("Thick Naskh 2", 12F);
            this._user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this._user.Location = new System.Drawing.Point(70, 319);
            this._user.Name = "_user";
            this._user.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._user.Size = new System.Drawing.Size(237, 68);
            this._user.TabIndex = 14;
            this._user.Text = "المستخدمين";
            this._user.UseVisualStyleBackColor = true;
            this._user.Click += new System.EventHandler(this._user_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("المحارب2 حديث", 18F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(281, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 44);
            this.label1.TabIndex = 20;
            this.label1.Text = "سلسلة مطاعم الخليل السياحية";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("المحارب2 حديث", 8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(311, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "عمل طلاب قسم تقنية المعلومات مستوى ثاني جامعة السعيدة";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("المحارب2 حديث", 8F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(260, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "ايمن الميثالي - علي الحسني - خليل ابراهيم - اركان ناصر - نايف حامس - اكرم الشعيبي" +
    "";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(857, 507);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._log);
            this.Controls.Add(this._purchsaing);
            this.Controls.Add(this._iteminf);
            this.Controls.Add(this._bill);
            this.Controls.Add(this.supplier);
            this.Controls.Add(this._user);
            this.Controls.Add(this.clo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button clo;
        private System.Windows.Forms.Button _log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button _user;
        public System.Windows.Forms.Button supplier;
        public System.Windows.Forms.Button _bill;
        public System.Windows.Forms.Button _iteminf;
        public System.Windows.Forms.Button _purchsaing;
    }
}

