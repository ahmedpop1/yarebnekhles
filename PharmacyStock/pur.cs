using PharmacyStock.Classes;
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
    public partial class pur : Form
    {

        PharmacyContext db ;
        SupplyBill supplyBill;
        DrugInSuppliedBill drugInSuppliedBill ;

        
        double Buy = 0 , sell = 0, Quantity = 0 , TBuy = 0, Tsell = 0, Penif = 0;
        public int id, counter, SID;


        public pur()
        {
            InitializeComponent();
            counter = 0;
            id=0;

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void sell_Text_TextChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Buy_Text_TextChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();

            if (textBox6.Text == "" || textBox1.Text == "" || label5.Text == "" || textBox2.Text == "" || numericUpDown1.Value == 0)
            {
                toast.Width = this.Width;
                toast.Sms_tost.Text = "Fild is Empty !!!!!!!!";
                toast.Show();

            }
            counter++;
            
            if (counter == 1 && id == 0)

            {
                supplyBill = new SupplyBill()
                {
                    PharmacistID = int.Parse(textBox6.Text),
                    SupplierID = int.Parse(textBox1.Text),
                    DateofEntry = dateTimePicker1.Value,
                    TotalPrice = double.Parse(label5.Text),
                    Selling_Price = double.Parse(sell_Text.Text),
                };
                db = new PharmacyContext();

                db.supplyBills.Add(supplyBill);
                db.SaveChanges();

                supplyBill.Selling_Price = double.Parse(sell_Text.Text);
                supplyBill.TotalPrice = double.Parse(label5.Text);
                db.SaveChanges();
                 SID = db.supplyBills.Select(supplyBill => supplyBill.ID).Max();
                drugInSuppliedBill = new DrugInSuppliedBill()
                {
                    BillID = SID,
                    DrugWithExpirationID = Int32.Parse(textBox2.Text),
                    Amount = Int32.Parse(numericUpDown1.Text),
                };
                db = new PharmacyContext();
                db.DrugsInSuppliedBill.Add(drugInSuppliedBill);
                db.SaveChanges();
                toast.Sms_tost.Text = "Added successfully....";
                toast.Show();
                pur_add pur_Add = new pur_add();
                pur_Add.gridControl1.DataSource = db.supplyBills.ToList();
                pur_Add.gridControl1.DataSource = db.DrugsInSuppliedBill.ToList();

            }
            else
            {

                drugInSuppliedBill = new DrugInSuppliedBill()
                {
                    BillID = SID,
                    DrugWithExpirationID = Int32.Parse(textBox2.Text),
                    Amount = Int32.Parse(numericUpDown1.Text),
                };
                db = new PharmacyContext();
                db.DrugsInSuppliedBill.Add(drugInSuppliedBill);
                db.SaveChanges();

            }

            //else edit
        //    {
        //        // id = (int)gridView1.GetFocusedRowCellValue("ID");


        //        supplyBill = new SupplyBill()
        //        {
        //            PharmacistID = int.Parse(textBox6.Text),
        //            SupplierID = int.Parse(textBox1.Text),
        //            DateofEntry = dateTimePicker1.Value,
        //            TotalPrice = double.Parse(label5.Text),
        //        };
        //        supplyBill.TotalPrice = int.Parse(label5.Text);
        //        supplyBill.DateofEntry = dateTimePicker1.Value;
        //        db.SaveChanges();
        //        drugInSuppliedBill.DrugWithExpirationID = int.Parse(textBox2.Text);
        //        drugInSuppliedBill.Amount = int.Parse(numericUpDown1.Text);
        //        db.SaveChanges();
        //        db.Entry(supplyBill).State = System.Data.Entity.EntityState.Modified;
        //        db.Entry(drugInSuppliedBill).State = System.Data.Entity.EntityState.Modified;
        //        db.SaveChanges();
        //        toast.Sms_tost.Text = "Edited successfully....";
        //        toast.Show();
        //        db = new PharmacyContext();
        //        pur_add pur_Add = new pur_add();
        //        pur_Add.gridControl1.DataSource = db.supplyBills.ToList();
        //        pur_Add.gridControl1.DataSource = db.DrugsInSuppliedBill.ToList();
        //        pur_Add.gridControl1.DataSource = db.pharmacists.ToList();
        //        this.Close();



        //    }
        //}


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void Calculator()
        {

            Buy = double.Parse(Buy_Text.Text);
            sell = double.Parse(sell_Text.Text);
            Quantity = Convert.ToDouble(numericUpDown1.Value);
            Tsell = sell * Quantity;
            TBuy = Buy * Quantity;
            Penif = Tsell - TBuy;
            label5.Text = TBuy.ToString();
            label6.Text = Tsell.ToString();
            label7.Text = Penif.ToString();
        }

    }
}
