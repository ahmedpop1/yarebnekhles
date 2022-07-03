using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyStock
{
    public partial class purchasesbill : Form
    {
        public purchasesbill()
        {
            InitializeComponent();
        }

        private void txtDate1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDate1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                txtDate1.ContextMenu = new ContextMenu();
            }
        }

        private void txtTotal1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void purchasesbill_Load(object sender, EventArgs e)
        {
            txtName1.Focus();
            txtName1.Select();
            txtName1.SelectAll();
        }

        private void txtName1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cbxitems1.Focus();

            }
        }

        private void cbxitems1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtQty1.Focus();
                txtQty1.SelectAll();

            }
        }
    }
}
