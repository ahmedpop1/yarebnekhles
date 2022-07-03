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
    public partial class pharmacist: Form
    {
        public pharmacist()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void supp_add_Load(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        Pharmacist_add add;
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            
            if (add == null)
            {
                add = new Pharmacist_add();
            }
            add.ShowDialog();
        }
    }
}
