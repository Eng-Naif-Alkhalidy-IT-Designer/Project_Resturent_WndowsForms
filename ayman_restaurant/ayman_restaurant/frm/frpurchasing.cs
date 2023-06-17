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
    public partial class frpurchasing : Form
    {
        restaurantEntities db = new restaurantEntities();
       bool Isadd=true;
        public frpurchasing()
        {
            InitializeComponent();
            showdgv();
        }

        private void showdgv()
        {
            dgv.Rows.Clear();
            var data1 = db.select_purchasing();
            foreach (var item in data1)
            {
                object[] ob = new object[]
                {
                    item.p_id,item.p_name,item.p_namesupplier,item.p_category,item.p_quantity,item.p_price,item.p_idbill
                };
                dgv.Rows.Add(ob);
            }
            
           
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dgv.CurrentRow.Cells["dgvname"].Value.ToString();
            textBox2.Text = dgv.CurrentRow.Cells["dgvnamesupplier"].Value.ToString();
            textBox3.Text = dgv.CurrentRow.Cells["dgvbills"].Value.ToString();
            textBox4.Text = dgv.CurrentRow.Cells["dgvcategory"].Value.ToString();
            textBox5.Text = dgv.CurrentRow.Cells["dgvqu"].Value.ToString();
            textBox7.Text = dgv.CurrentRow.Cells["dgvprice"].Value.ToString();

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void clo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            EnableDisabl(true);
            purchasing pu = new purchasing();
            if (Isadd == false)
            {
                int _id = int.Parse(dgv.CurrentRow.Cells["dgvid"].Value.ToString());
                pu = db.purchasings.Find(_id);
            }
            else
            {
                pu = new purchasing();
            }

            try
            {
                if(textBox1.Text!=""|| textBox2.Text!=""|| textBox4.Text!=""|| textBox5.Text!="" || textBox7.Text!="")
                {
                    pu.p_name = textBox1.Text;
                    pu.p_namesupplier = textBox2.Text;
                    pu.p_idbill = int.Parse(textBox3.Text);
                    pu.p_category = textBox4.Text;
                    pu.p_quantity = textBox5.Text;
                    pu.p_price = int.Parse(textBox7.Text);
                    if (Isadd)
                        db.purchasings.Add(pu);
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
           
        }

        private void EnableDisabl(bool v)
        {
            groupBox1.Enabled = !v;
            groupBox2.Enabled = v;
            groupBox3.Enabled = !v;
        }

        private void clearsa()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Isadd = false;
            EnableDisabl(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("هل تريد الحذف", "تاكيد", MessageBoxButtons.YesNo))
            {
                int _id = int.Parse(dgv.CurrentRow.Cells["dgvid"].Value.ToString());

                var s1 = db.purchasings.Find(_id);
                db.purchasings.Remove(s1);
                db.SaveChanges();
                MessageBox.Show("تم الحذف");
                showdgv();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clearsa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnableDisabl(false);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

        
    

