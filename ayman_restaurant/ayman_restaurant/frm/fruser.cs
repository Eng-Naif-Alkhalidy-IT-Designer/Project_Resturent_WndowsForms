using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ayman_restaurant
{
    public partial class fruser : Form
    {
        restaurantEntities db = new restaurantEntities();
        bool Isadd = false;

        public fruser()
        {
            InitializeComponent();
            EnableDisabl(false);
            showdgv();
        }
        private void EnableDisabl(bool v)
        {
            groupBox2.Enabled = v;
            groupBox1.Enabled = v;
            groupBox3.Enabled = v;


        }
        private void showdgv()
        {
            dgv.Rows.Clear();
            var data = db.select_user();
            foreach (var item in data)
            {
                object[] ob = new object[]
                {
                   item.u_id, item.u_name,item.u_pass,item.u_user,item.u_supplier,item.bill,item.purchasing,item.product
                };
                dgv.Rows.Add(ob);

            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dgv.CurrentRow.Cells["dgvname"].Value.ToString();
            textBox2.Text = dgv.CurrentRow.Cells["dgvpass"].Value.ToString();

            if (dgv.CurrentRow.Cells["dgvuser"].Value.ToString() == "yes")
            {

                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
            if (dgv.CurrentRow.Cells["dgvsupplier"].Value.ToString() == "yes")
            {

                checkBox2.Checked = true;
            }
            else
            {
                checkBox2.Checked = false;
            }
            if (dgv.CurrentRow.Cells["dgvbill"].Value.ToString() == "yes")
            {

                checkBox3.Checked = true;
            }
            else
            {
                checkBox3.Checked = false;
            }
            if (dgv.CurrentRow.Cells["dgvpur"].Value.ToString() == "yes")
            {

                checkBox4.Checked = true;
            }
            else
            {
                checkBox4.Checked = false;
            }
            if (dgv.CurrentRow.Cells["dgvpro"].Value.ToString() == "yes")
            {

                checkBox5.Checked = true;
            }
            else
            {
                checkBox5.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        private void clearsa()
        {
            textBox1.Clear();
            textBox2.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("هل تريد الحذف", "تاكيد", MessageBoxButtons.YesNo))
            {
                int _id = int.Parse(dgv.CurrentRow.Cells["dgvid"].Value.ToString());

                var s1 = db.users.Find(_id);
                db.users.Remove(s1);
                db.SaveChanges();
                MessageBox.Show("تم الحذف");
                showdgv();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            user us = new user();
            if (Isadd == false)
            {
                int _id = int.Parse(dgv.CurrentRow.Cells["dgvid"].Value.ToString());
                us = db.users.Find(_id);
            }
            else
            {
                us = new user();
            }
            string c1, c2, c3, c4, c5;
            if (checkBox1.Checked == true)
            {
                c1 = "yes";
            }
            else
            {
                c1 = "no";
            }
            if (checkBox2.Checked == true)
            {
                c2 = "yes";
            }
            else
            {
                c2 = "no";
            }
            if (checkBox3.Checked == true)
            {
                c3 = "yes";
            }
            else
            {
                c3 = "no";
            }
            if (checkBox4.Checked == true)
            {
                c4 = "yes";
            }
            else
            {
                c4 = "no";
            }
            if (checkBox5.Checked == true)
            {
                c5 = "yes";
            }
            else
            {
                c5 = "no";
            }
            try
            {

               if(textBox1.Text!="" || textBox2.Text!="")
                {
                    us.u_name = textBox1.Text;
                    us.u_pass = textBox2.Text;
                    us.u_user = c1;
                    us.u_supplier = c2;
                    us.bill = c3;
                    us.purchasing = c4;
                    us.product = c5;
                    if (Isadd)
                        db.users.Add(us);
                    db.SaveChanges();
                    MessageBox.Show("تم العملية بنجاح");
                }
               else
                {
                    MessageBox.Show("احد الحقول فارغة");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("no", ex.Message);
            }

            showdgv();
            clearsa();
            EnableDisabl(false);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            EnableDisabl(true);
            clearsa();
            Isadd = true;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            EnableDisabl(true);
            Isadd = false;
        }

        private void clo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            clearsa();
            EnableDisabl(false);
        }
    }
}
