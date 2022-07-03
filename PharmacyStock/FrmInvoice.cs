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
    public partial class FrmInvoice : Form
    {
        public FrmInvoice()
        {
            InitializeComponent();
        }


        // show Date 
        private void FrmInvoice_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("yyyy/MM/dd");


            txtName.Focus();
            txtName.Select();
            txtName.SelectAll();
        }


        // event for Date not writes any thing input the textbox
        private void txtDate_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                txtDate.ContextMenu = new ContextMenu();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Enter)
            {
                cbxitems.Focus();
                cbxitems.Select();
            }
        }

        private void cbxitems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtQty.Focus();
                txtQty.SelectAll();
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnAdd.PerformClick();
                cbxitems.Focus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add");
        }
    }
}
