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

    public partial class frproudect : Form
    {
        restaurantEntities db = new restaurantEntities();
        bool Isadd = false;
        public frproudect()
        {
            InitializeComponent();
            //
            var datacat = db.select_category();
            cbxcatgorypro.DataSource = datacat;
            //
            var datadap = db.select_department();
            cbxdepartmentpro.DataSource = datadap;
            showdgv();
            EnableDisabl(false);
        }
        private void EnableDisabl(bool v)
        {

            groupBox2.Enabled = !v;
          
            groupBox3.Enabled = v;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void clo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbxcatgorypro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            itemsinfo itf = new itemsinfo();
            if (Isadd == false)
            {
                int _id = int.Parse(dataGridView1.CurrentRow.Cells["dgvid"].Value.ToString());
                itf = db.itemsinfoes.Find(_id);
            }
            else
            {
                itf = new itemsinfo();
            }

            try
            {
                
                if(tbxnamepro.Text!="")
                {
                    itf.item = tbxnamepro.Text;
                    itf.category = cbxcatgorypro.Text;
                    itf.department = cbxdepartmentpro.Text;
                    itf.price = int.Parse(tbxpricepro.Text);
                    if (Isadd)
                        db.itemsinfoes.Add(itf);

                    db.SaveChanges();
                    MessageBox.Show("تم الحفظ بنجاح");
                }
                else
                {
                    errorProvider1.SetError(tbxnamepro, "j");
                    //MessageBox.Show("اسم المنتج فارغ");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("no", ex.Message);

            }
            showdgv();
            EnableDisabl(false);
        }
        private void showdgv()
        {
            dataGridView1.Rows.Clear();
            var data = db.select_itemsinfo();
            foreach (var item in data)
            {
                object[] ob = new object[]
                {
                   item.id, item.item,item.category,item.department,item.price
                };
                dataGridView1.Rows.Add(ob);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Isadd = false;
            EnableDisabl(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Isadd = true;
            EnableDisabl(true);
            clera();
        }

        private void clera()
        {
            tbxnamepro.Clear();
            tbxpricepro.Clear();
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxnamepro.Text=dataGridView1.CurrentRow.Cells["dgvname"].Value.ToString();
            cbxcatgorypro.Text= dataGridView1.CurrentRow.Cells["dgvcategory"].Value.ToString();
            cbxdepartmentpro.Text= dataGridView1.CurrentRow.Cells["dgvdepartment"].Value.ToString();
            tbxpricepro.Text = dataGridView1.CurrentRow.Cells["dgvprice"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("هل تريد الحذف", "تاكيد", MessageBoxButtons.YesNo))
            {
                int _id = int.Parse(dataGridView1.CurrentRow.Cells["dgvid"].Value.ToString());

                var s1 = db.itemsinfoes.Find(_id);
                db.itemsinfoes.Remove(s1);
                db.SaveChanges();
                MessageBox.Show("تم الحذف");
                showdgv();
            }
            clera();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
