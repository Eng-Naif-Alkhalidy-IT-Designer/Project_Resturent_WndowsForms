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
    public partial class main : Form
    {
        restaurantEntities db = new restaurantEntities();

        public main()
        {
            InitializeComponent();
        }

        private void _log_Click(object sender, EventArgs e)
        {
            login_in lo_in = new login_in();
            lo_in.Show();
        }

        private void clo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _iteminf_Click(object sender, EventArgs e)
        {
            frproudect _pro = new frproudect();
            _pro.Show();
        }

        private void _user_Click(object sender, EventArgs e)
        {
            fruser _user = new fruser();
            _user.Show();
        }

        private void _bill_Click(object sender, EventArgs e)
        {
            frbilladd _bill = new frbilladd();
            _bill.Show();
        }

        private void supplier_Click(object sender, EventArgs e)
        {
            frsupplier _supp = new frsupplier();
            _supp.Show();
        }

        private void _purchsaing_Click(object sender, EventArgs e)
        {
          //  if(db.users.Where())
            frpurchasing pu = new frpurchasing();
            pu.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {
            
        }
    }
}
