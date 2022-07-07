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
    public partial class pur_add : Form
    {
        PharmacyContext db;
        SupplyBill supplyBill ;
        DrugInSuppliedBill drugInSuppliedBill = new DrugInSuppliedBill();

        int id = 0;
       // PharmacyStock.pur_add();

        public pur_add()
        {
            InitializeComponent();
            db = new PharmacyContext();
            var showdetitle = db.DrugsInSuppliedBill.Include("SupplyBill")
                .Select(S => new
                {
                    S.SuppliedBill.ID,
                    S.SuppliedBill.PharmacistID,
                    S.SuppliedBill.SupplierID,
                    S.SuppliedBill.DateofEntry,
                    S.SuppliedBill.TotalPrice,
                    S.SuppliedBill.Selling_Price,
                    S.DrugWithExpirationID,
                    S.Amount
                 

                }).ToList();

            gridControl1.DataSource = showdetitle;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        { 
            pur pur = new pur();
            pur.Show();



        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            var showdetitle = db.DrugsInSuppliedBill.Include("SupplyBill")
                .Select(S => new
                {
                    S.SuppliedBill.ID,
                    S.SuppliedBill.PharmacistID,
                    S.SuppliedBill.SupplierID,
                    S.SuppliedBill.DateofEntry,
                    S.SuppliedBill.TotalPrice,
                    S.SuppliedBill.Selling_Price,
                    S.DrugWithExpirationID,
                    S.Amount


                }).ToList();

            gridControl1.DataSource = showdetitle;

        }



        private void simpleButton1_Click(object sender, EventArgs e)
        { 
            pur pur = new pur();
            supplyBill = new SupplyBill();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            supplyBill=db.supplyBills.Where(s => s.ID == id).FirstOrDefault();
            pur.textBox6.Text = supplyBill.PharmacistID.ToString();
            pur.textBox1.Text = supplyBill.SupplierID.ToString();
            pur.label5.Text=supplyBill.TotalPrice.ToString();
            pur.dateTimePicker1.Text=supplyBill.DateofEntry.ToString();
            pur.textBox2.Text = drugInSuppliedBill.DrugWithExpirationID.ToString();
            pur.numericUpDown1.Text = drugInSuppliedBill.Amount.ToString();
            pur.Add.Text = "Edit";
            pur.Show();

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            var search =int.Parse(textBox1.Text);
            gridControl1.DataSource= db.supplyBills.Where(z => z.PharmacistID.Equals(search)|| z.SupplierID.Equals(search)).ToList();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            id = (int)gridView1.GetFocusedRowCellValue("ID");
            if (id > 0)
            {
                try
                { 

               
                    var sh = MessageBox.Show("Delete Operation", "Are You Suer To Delete This Row .....", MessageBoxButtons.YesNo);
                    if (sh == DialogResult.Yes)

                    {
                        supplyBill = db.supplyBills.Where(y => y.ID == id).FirstOrDefault();
                        db.Entry(supplyBill).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        db.Entry(drugInSuppliedBill).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        toast.Sms_tost.Text = "Deleted successfully....";
                        toast.Show();
                       
                    }
                    else
                    {
                        toast.Sms_tost.Text = "You Press No....";
                        toast.Show();

                    }

                }
                
                catch
                {
                    toast.Sms_tost.Text = " There Is No item to Deleted !!!!";


                }
            }   
            
        }
    }
}
