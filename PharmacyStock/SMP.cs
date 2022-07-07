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
            this.Location
           = new Point(10, 20);

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
            this.Close();
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
        Category c1;
        Form Active;
        private void Categories_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            //Environment.Exit(0);
            if (c1 == null) {
                c1 = new Category(); }

            c1.TopLevel = false;
            panel1.Controls.Add(c1);
            c1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            var c=c1.Controls;
            c["panel1"].Size = new System.Drawing.Size(1046, 96);
            c["panel1"].Controls["simpleButton3"].Location = new System.Drawing.Point(20, 20);
            c["panel1"].Controls["simpleButton3"].Size = new System.Drawing.Size(110, 60);
            c["panel1"].Controls["simpleButton1"].Location = new System.Drawing.Point(150, 20);
            c["panel1"].Controls["simpleButton1"].Size = new System.Drawing.Size(110, 60);
            c["panel1"].Controls["simpleButton2"].Location = new System.Drawing.Point(270, 20);
            c["panel1"].Controls["simpleButton2"].Size = new System.Drawing.Size(110, 60);
            c["panel1"].Controls["simpleButton4"].Location = new System.Drawing.Point(400, 20);
            c["panel1"].Controls["simpleButton4"].Size = new System.Drawing.Size(110, 60);
            c["panel1"].Controls["textBox1"].Location= new System.Drawing.Point(600, 30);
            c["panel1"].Controls["simpleButton5"].Location =new System.Drawing.Point(1040, 30);
            c["panel1"].Controls["simpleButton5"].Size= new System.Drawing.Size(40, 40);

            // MessageBox.Show(.Name);

            c1.Dock = DockStyle.Fill;
           
            c1.Show();
        }
        //Suppliers

        supp_add suppliers;
        private void Suppliers_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (suppliers == null)
            {
                suppliers = new supp_add();
            }
            suppliers.TopLevel = false;
            panel1.Controls.Add(suppliers);
            suppliers.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            var c = suppliers.Controls;
            c["panel1"].Size = new System.Drawing.Size(1046, 96);
            c["panel1"].Controls["simpleButton3"].Location = new System.Drawing.Point(20, 20);
            c["panel1"].Controls["simpleButton3"].Size = new System.Drawing.Size(110, 60);
            c["panel1"].Controls["simpleButton1"].Location = new System.Drawing.Point(150, 20);
            c["panel1"].Controls["simpleButton1"].Size = new System.Drawing.Size(110, 60);
            c["panel1"].Controls["simpleButton2"].Location = new System.Drawing.Point(270, 20);
            c["panel1"].Controls["simpleButton2"].Size = new System.Drawing.Size(110, 60);
            c["panel1"].Controls["simpleButton4"].Location = new System.Drawing.Point(400, 20);
            c["panel1"].Controls["simpleButton4"].Size = new System.Drawing.Size(110, 60);
            c["panel1"].Controls["textBox1"].Location = new System.Drawing.Point(600, 30);
            c["panel1"].Controls["simpleButton5"].Location = new System.Drawing.Point(1040, 30);
            c["panel1"].Controls["simpleButton5"].Size = new System.Drawing.Size(40, 40);
            suppliers.Dock = DockStyle.Fill;

            suppliers.Show();

            // Environment.Exit(0);
        }
        //Cardes
        supplies suppliees;
        private void Cardes_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (suppliees == null)
            {
                suppliees = new supplies();
            }
            suppliees.TopLevel = false;
            panel1.Controls.Add(suppliees);
            suppliees.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            var c = suppliees.Controls;
            c["panel1"].Size = new System.Drawing.Size(1046, 96);
            c["panel1"].Controls["simpleButton3"].Location = new System.Drawing.Point(20, 20);
            c["panel1"].Controls["simpleButton3"].Size = new System.Drawing.Size(110, 60);
            c["panel1"].Controls["simpleButton1"].Location = new System.Drawing.Point(150, 20);
            c["panel1"].Controls["simpleButton1"].Size = new System.Drawing.Size(110, 60);
            c["panel1"].Controls["simpleButton2"].Location = new System.Drawing.Point(270, 20);
            c["panel1"].Controls["simpleButton2"].Size = new System.Drawing.Size(110, 60);
            c["panel1"].Controls["simpleButton4"].Location = new System.Drawing.Point(400, 20);
            c["panel1"].Controls["simpleButton4"].Size = new System.Drawing.Size(110, 60);
            c["panel1"].Controls["textBox1"].Location = new System.Drawing.Point(600, 30);
            c["panel1"].Controls["simpleButton5"].Location = new System.Drawing.Point(1040, 30);
            c["panel1"].Controls["simpleButton5"].Size = new System.Drawing.Size(40, 40);
            suppliees.Dock = DockStyle.Fill;

            suppliees.Show();
            
            //Environment.Exit(0);
        }
        //Customers
        private void Customers_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);
        }
        //Sales
        sales saless;
        private void Sales_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (saless == null)
            {
                saless = new sales();
            }
            saless.TopLevel = false;
            panel1.Controls.Add(saless);
            saless.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            var c = saless.Controls;
            c["panel1"].Size = new System.Drawing.Size(1046, 96);
            c["panel1"].Controls["simpleButton3"].Location = new System.Drawing.Point(20, 20);
            c["panel1"].Controls["simpleButton3"].Size = new System.Drawing.Size(110, 60);
            c["panel1"].Controls["simpleButton1"].Location = new System.Drawing.Point(150, 20);
            c["panel1"].Controls["simpleButton1"].Size = new System.Drawing.Size(110, 60);
            c["panel1"].Controls["simpleButton2"].Location = new System.Drawing.Point(270, 20);
            c["panel1"].Controls["simpleButton2"].Size = new System.Drawing.Size(110, 60);
            c["panel1"].Controls["simpleButton4"].Location = new System.Drawing.Point(400, 20);
            c["panel1"].Controls["simpleButton4"].Size = new System.Drawing.Size(110, 60);
            c["panel1"].Controls["textBox1"].Location = new System.Drawing.Point(600, 30);
            c["panel1"].Controls["simpleButton5"].Location = new System.Drawing.Point(1040, 30);
            c["panel1"].Controls["simpleButton5"].Size = new System.Drawing.Size(40, 40);
            saless.Dock = DockStyle.Fill;

            saless.Show();
            //Environment.Exit(0);
        }
        //Users

        pharmacist pharmac;
        private void Users_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (pharmac == null)
            {
                pharmac = new pharmacist();
            }
            pharmac.TopLevel = false;
            panel1.Controls.Add(pharmac);
            pharmac.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            var c = pharmac.Controls;
            c["panel1"].Size = new System.Drawing.Size(1046, 96);
            c["panel1"].Controls["simpleButton3"].Location = new System.Drawing.Point(20, 20);
            c["panel1"].Controls["simpleButton3"].Size = new System.Drawing.Size(110, 60);
            c["panel1"].Controls["simpleButton1"].Location = new System.Drawing.Point(150, 20);
            c["panel1"].Controls["simpleButton1"].Size = new System.Drawing.Size(110, 60);
            c["panel1"].Controls["simpleButton2"].Location = new System.Drawing.Point(270, 20);
            c["panel1"].Controls["simpleButton2"].Size = new System.Drawing.Size(110, 60);
            c["panel1"].Controls["simpleButton4"].Location = new System.Drawing.Point(400, 20);
            c["panel1"].Controls["simpleButton4"].Size = new System.Drawing.Size(110, 60);
            c["panel1"].Controls["textBox1"].Location = new System.Drawing.Point(600, 30);
            c["panel1"].Controls["simpleButton5"].Location = new System.Drawing.Point(1040, 30);
            c["panel1"].Controls["simpleButton5"].Size = new System.Drawing.Size(40, 40);
            pharmac.Dock = DockStyle.Fill;

            pharmac.Show();

            // Environment.Exit(0);
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

        private void SMP_Load(object sender, EventArgs e)
        {

        }
    }
}
