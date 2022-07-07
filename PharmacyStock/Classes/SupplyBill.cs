﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PharmacyStock.Classes
{
    internal class SupplyBill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ID { get; set; }
        [ForeignKey("pharmacist")]
        public int PharmacistID { get; set; }
        [ForeignKey("Supplier")]
        public int SupplierID { get; set; }
       
       // [ForeignKey("Drug")]
       // public int DrugID { get; set; }
        public double? TotalPrice { get; set; }

        public double Selling_Price { get; set; }
        public DateTime DateofEntry { get; set; }
       // public int MyProperty { get; set; }
        public Supplier Supplier { get; set; }
        public Pharmacist pharmacist { get; set; }
       // public List<DrugInSuppliedBill> DrugsInSuppliedBill { get; set; }



    }
}
