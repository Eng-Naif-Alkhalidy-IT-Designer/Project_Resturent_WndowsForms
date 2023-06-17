using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ayman_restaurant
{
    public partial class login_in : Form
    {
        
        public login_in()
        {
            InitializeComponent();
        }

        private void btnclo_Click(object sender, EventArgs e)
        {
            main m = new main();
            m.Close();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                restaurantEntities db = new restaurantEntities();
                var RESULT = db.users.Where(x => x.u_name == tbxnamelog.Text && x.u_pass == tbxpasslog.Text).ToList();
                if (RESULT.Count > 0)
                {
                    main mi1 = new main();
                    mi1.Show();
                    this.Hide();
                    string _us, _sup,_bil,_pur,_pro;
                    //الصلاحيات 
                    var datad = db.users.Where(x => x.u_name == tbxnamelog.Text).ToList();
                    foreach (var item in datad)
                    {

                        _us = item.u_user;
                       _pro= item.product;
                       _pur= item.purchasing;
                       _sup= item.u_supplier;
                       _bil= item.bill;
                        if (_us == "yes")
                        {
                            mi1._user.Enabled = true;
                        }
                        else
                        {
                            mi1._user.Enabled = false;
                        }
                        if (_sup == "yes")
                        {
                            mi1.supplier.Enabled = true;
                        }
                        else
                        {
                            mi1.supplier.Enabled = false;
                        }
                        if (_bil == "yes")
                        {
                            mi1._bill.Enabled = true;
                        }
                        else
                        {
                            mi1._bill.Enabled = false;
                        }
                        if (_pro == "yes")
                        {
                            mi1._iteminf.Enabled = true;
                        }
                        else
                        {
                            mi1._iteminf.Enabled = false;
                        }
                        if (_pur == "yes")
                        {
                            mi1._purchsaing.Enabled = true;
                        }
                        else
                        {
                            mi1._purchsaing.Enabled = false;
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("اسم المستخدم او كلمة المرور خاطئة");
                    tbxnamelog.Clear();
                    tbxpasslog.Clear();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }
        
    }
}
