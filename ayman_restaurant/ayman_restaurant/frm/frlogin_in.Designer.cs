namespace ayman_restaurant
{
    partial class login_in
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.tbxnamelog = new System.Windows.Forms.TextBox();
            this.tbxpasslog = new System.Windows.Forms.TextBox();
            this.btnclo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "الاسم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "كلمة السر";
            // 
            // btnlogin
            // 
            this.btnlogin.BackgroundImage = global::ayman_restaurant.Properties.Resources.tt;
            this.btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Location = new System.Drawing.Point(162, 136);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(100, 23);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "دخول";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // tbxnamelog
            // 
            this.tbxnamelog.Location = new System.Drawing.Point(56, 60);
            this.tbxnamelog.Name = "tbxnamelog";
            this.tbxnamelog.Size = new System.Drawing.Size(147, 20);
            this.tbxnamelog.TabIndex = 4;
            // 
            // tbxpasslog
            // 
            this.tbxpasslog.Location = new System.Drawing.Point(56, 96);
            this.tbxpasslog.Name = "tbxpasslog";
            this.tbxpasslog.Size = new System.Drawing.Size(147, 20);
            this.tbxpasslog.TabIndex = 5;
            // 
            // btnclo
            // 
            this.btnclo.BackgroundImage = global::ayman_restaurant.Properties.Resources.rr;
            this.btnclo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclo.FlatAppearance.BorderSize = 0;
            this.btnclo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclo.Location = new System.Drawing.Point(60, 136);
            this.btnclo.Name = "btnclo";
            this.btnclo.Size = new System.Drawing.Size(100, 23);
            this.btnclo.TabIndex = 6;
            this.btnclo.Text = "خروج";
            this.btnclo.UseVisualStyleBackColor = true;
            this.btnclo.Click += new System.EventHandler(this.btnclo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "تسجيل الدخول";
            // 
            // login_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(318, 181);
            this.Controls.Add(this.btnclo);
            this.Controls.Add(this.tbxpasslog);
            this.Controls.Add(this.tbxnamelog);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login_in";
            this.Text = "login_in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox tbxnamelog;
        private System.Windows.Forms.TextBox tbxpasslog;
        private System.Windows.Forms.Button btnclo;
        private System.Windows.Forms.Label label3;
    }
}