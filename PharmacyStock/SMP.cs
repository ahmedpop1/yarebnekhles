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
    public partial class SMP : Form
    {
        public SMP()
        {
            InitializeComponent();
        }



        //close app

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //btn1exampel
            Environment.Exit(0);
        }




        //btn_close
        private void btn_close_Click(object sender, EventArgs e)
        {
            
            Environment.Exit(0);
        }

        //btn_min
        private void btn_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

            //Environment.Exit(0);
        }

        //btn_max
        private void btn_max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                WindowState = FormWindowState.Normal;

            }
            //Environment.Exit(0);
        }
        //btn_not
        private void btn_not_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);
        }
        //Home
        private void home_ptn_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);
        }
        //Categories
        private void Categories_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);
        }
        //Suppliers
        private void Suppliers_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);
        }
        //Cardes
        private void Cardes_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);
        }
        //Customers
        private void Customers_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);
        }
        //Sales
        private void Sales_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);
        }
        //Users
        private void Users_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);
        }
        //Reports
        private void Reports_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);
        }
        //Settings
        private void Settings_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);
        }
















        private void Home_Click(object sender, EventArgs e)
        {

        }
    }
}
