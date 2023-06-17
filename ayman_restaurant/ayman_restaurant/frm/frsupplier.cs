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
    public partial class frsupplier : Form
    {
        restaurantEntities db = new restaurantEntities();
        bool Isadd = true;
        public frsupplier()
        {
            InitializeComponent();
            showdgv();
            EnableDisabl(false);
        }

        private void showdgv()
        {
            try
            {
                dgv.Rows.Clear();
                var data1 = db.select_supplier();
                foreach (var item in data1)
                {
                    object[] ob = new object[]
                    {
                    item.s_id,item.s_name,item.s_name_company,item.s_address,item.s_phon,item.s_fex
                    };
                    dgv.Rows.Add(ob);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("no", ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            supplier su1 = new supplier();
            if (Isadd == false)
            {
                int _id = int.Parse(dgv.CurrentRow.Cells["dgvid"].Value.ToString());
                su1 = db.suppliers.Find(_id);
            }
            else
            {
                su1 = new supplier();
            }
            try
            {
                
                if(tbxname.Text!=""|| tbxaddress.Text!=""|| tbxnamead.Text!=""|| tbxphon.Text!=""|| tbxfex.Text!="")
                {
                    su1.s_name = tbxname.Text;
                    su1.s_address = tbxaddress.Text;
                    su1.s_name_company = tbxnamead.Text;
                    su1.s_phon = int.Parse(tbxphon.Text);
                    su1.s_fex = tbxfex.Text;
                    if (Isadd)
                        db.suppliers.Add(su1);
                    db.SaveChanges();

                    MessageBox.Show("تم الحفظ بنجاح");
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
            EnableDisabl(false);
        }

        private void EnableDisabl(bool v)
        {
            groupBox1.Enabled = !v;
            groupBox2.Enabled = !v;
            groupBox3.Enabled = v;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("هل تريد الحذف", "تاكيد", MessageBoxButtons.YesNo))
            {
                int _id = int.Parse(dgv.CurrentRow.Cells["dgvid"].Value.ToString());

                var s1 = db.suppliers.Find(_id);
                db.suppliers.Remove(s1);
                db.SaveChanges();
                MessageBox.Show("تم الحذف");
                showdgv();
            }
            clera();
        }

        private void clera()
        {
            tbxname.Clear();
            tbxnamead.Clear();
            tbxphon.Clear();
            tbxfex.Clear();
            tbxaddress.Clear();
        }

        private void clo_Click(object sender, EventArgs e)
        {
            Close();
            main m = new main();
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnableDisabl(true);
            Isadd = true;
            clera();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clera();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxname.Text = dgv.CurrentRow.Cells["dgv_name"].Value.ToString();
            tbxnamead.Text = dgv.CurrentRow.Cells["dgvs_name_company"].Value.ToString();
            tbxaddress.Text = dgv.CurrentRow.Cells["dgv_address"].Value.ToString();
            tbxphon.Text = dgv.CurrentRow.Cells["dgvs_phon"].Value.ToString();
            tbxfex.Text = dgv.CurrentRow.Cells["dgvs_fex"].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnableDisabl(true);
            Isadd = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbxphon_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbxname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tbxfex_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxnamead_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxaddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
