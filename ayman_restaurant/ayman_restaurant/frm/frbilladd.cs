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
   

    public partial class frbilladd : Form
    {
        restaurantEntities db = new restaurantEntities();

        public frbilladd()
        {
            InitializeComponent();
            showdgvcat();
           

        }
       
        private void showdgvcat()
        {
            var datacat = db.select_department();
            dgvcat.Rows.Add("الكل");
            foreach (var item in datacat)
            {
                object[] bt = new object[]
                {
                    item
                };
                dgvcat.Rows.Add(bt);
            }
        }

        private void clo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvcat1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void dgvitemandprice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
            try
            {
                var pos = dgv.CurrentRow.Index;
                string ditem = dgv.CurrentRow.Cells["dgvitem"].Value.ToString();
                int dprice =int.Parse( dgv.Rows[pos].Cells["dgvprice"].Value.ToString());
                //
              
               
                for (int i = 0; i <= dgvbill.Rows.Count - 1; i++)
                {
                    if (dgvbill.Rows[i].Cells["dgvitems"].Value.ToString() == ditem)
                    {
                        MessageBox.Show("المنتج الذي اخترته مضاف فعلاً الى فتورة المبيعات");
                        return;
                    }
                }
                
                for (int i = 0; i <= dgvbill.Rows.Count- 1 ; i++)
                {
                    var lastrow = dgvbill.Rows.Count - 1;
                    if (dgvbill.Rows[i].Cells["dgvitems"].Value.ToString() == "المجموع")
                    {
                        dgvbill.Rows.RemoveAt(lastrow);
                    }
                }
                //
                dgvbill.Rows.Add( );
                var RowsCount1 = dgvbill.Rows.Count-1;

                dgvbill.Rows[RowsCount1].Cells["dgvno"].Value = RowsCount1+1;
                dgvbill.Rows[RowsCount1].Cells["dgvitems"].Value = ditem;
                dgvbill.Rows[RowsCount1].Cells["dgvnumber"].Value = 1;
                dgvbill.Rows[RowsCount1].Cells["dgvprices"].Value = dprice;
                dgvbill.Rows[RowsCount1].Cells["dgvtotal"].Value = dprice*1;

                dgvbill.Rows.Add();
                var Rowstotal = dgvbill.Rows.Count - 1;
                dgvbill.Rows[Rowstotal].Cells["dgvitems"].Value = "المجموع";
                dgvbill.Rows[Rowstotal].Cells["dgvnumber"].Value = 0;
                dgvbill.Rows[Rowstotal].Cells["dgvprices"].Value = 0;
                sumtotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
       public void sumtotal()
        {
            var Rowstotal1 = dgvbill.Rows.Count - 1;
            double sumRowtotal = 0;
            for (int i = 0; i < dgvbill.Rows.Count - 1; i++)
            {
                sumRowtotal += int.Parse(dgvbill.Rows[i].Cells["dgvtotal"].Value.ToString());
            }
            dgvbill.Rows[Rowstotal1].Cells["dgvtotal"].Value = sumRowtotal;
            textBox3.Text = sumRowtotal.ToString();
        }

        private void dgvitemandprice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           var data1 = db.itemsinfoes.ToList();
            dgv.Rows.Clear();
            string d = dgvcat.CurrentRow.Cells["dgvcategory"].Value.ToString();
            if (d != "الكل")
            {
                 data1 = db.itemsinfoes.Where(x => x.department == d).ToList();
                
            }
            else
            {
                data1 = db.itemsinfoes.ToList();
            }
                
            
                foreach (var item in data1)
            {
                object[] bt = new object[]
                {
                   item.item,item.price
                };
                dgv.Rows.Add(bt);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int maxId;
            if (db.tblbills.Max(x => x.bill_id).ToString() != null)
            {
                int damax = int.Parse(db.tblbills.Max(x => x.bill_id).ToString());
                 maxId = damax + 1;
            }
            else
            {
                maxId=0;
            }

            try
            {
                tblbill tb =new tblbill();
                for (int i = dgvbill.Rows.Count - 1; i >= 0; i--)
                {
                
                   
                        tb.item_name = dgvbill.Rows[i].Cells["dgvitems"].Value.ToString();
                        int unit = int.Parse(dgvbill.Rows[i].Cells["dgvnumber"].Value.ToString());
                        tb.units = unit;
                        float pric = float.Parse(dgvbill.Rows[i].Cells["dgvprices"].Value.ToString());
                        tb.unit_pric = pric;
                        //
                        float tot = float.Parse(dgvbill.Rows[i].Cells["dgvtotal"].Value.ToString());
                        tb.unit_total = tot;
                        tb.bill_id = maxId;
                        tb.bill_date = dateTimePicker1.Value;
                    if(textBox1.Text!=""&& dgvbill.Rows[i].Cells["dgvitems"].Value.ToString() == "المجموع")
                    {
                        float discount = float.Parse(textBox1.Text);
                        tb.discount = discount;
                        if (radioButton1.Checked==true)
                        {
                            tb.net = tot - discount;
                        }
                        else if(radioButton2.Checked == true)
                        {
                            float ptc = tot * discount / 100;
                            tb.net = tot - ptc;
                        }
                        else
                        {
                            tb.net = 0;
                        }
                    }
                        db.tblbills.Add(tb);
                        db.SaveChanges();
                
                dgvbill.Rows.RemoveAt(i);
            }
            MessageBox.Show("تم حفظ الفاتورة",""+maxId);
        }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void dgvbill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dgvbill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                if (dgvbill.CurrentRow.Cells["dgvitems"].Value.ToString() != "المجموع")
                {
                    var pos = dgv.CurrentRow.Index;
                    int dnumber = int.Parse(dgvbill.CurrentRow.Cells["dgvnumber"].Value.ToString());
                    int dprice = int.Parse(dgvbill.CurrentRow.Cells["dgvprices"].Value.ToString());
                    string item = dgvbill.CurrentRow.Cells["dgvitems"].Value.ToString();
                    int newnumber;
                    if (e.ColumnIndex == 5)
                    {
                        newnumber = dnumber + 1;
                        dgvbill.CurrentRow.Cells["dgvnumber"].Value = newnumber;
                        dgvbill.CurrentRow.Cells["dgvtotal"].Value = dprice * newnumber;
                        sumtotal();
                    }
                    else
                    if (e.ColumnIndex == 6)
                    {
                        if (dnumber == 1)
                        {
                            for (int i = dgvbill.Rows.Count - 1; i >= 0; i--)
                                if (item == dgvbill.Rows[i].Cells["dgvitems"].Value.ToString())
                                {
                                    

                                        dgvbill.Rows.RemoveAt(i);
                                    sumtotal();
                                }

                        }
                        else
                        {
                            newnumber = dnumber - 1;
                            dgvbill.CurrentRow.Cells["dgvnumber"].Value = newnumber;
                            dgvbill.CurrentRow.Cells["dgvtotal"].Value = dprice * newnumber;
                        }


                    }
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = dgvbill.Rows.Count - 1; i >=0  ; i--)
            {
                dgvbill.Rows.RemoveAt(i);
            }
        }

        private void dgvbill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
