using System;
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
        public int ID { get; set; }
        [ForeignKey("pharmacist")]
        public int PharmacistID { get; set; }
        [ForeignKey("Supplier")]
        public int SupplierID { get; set; }
       
       // [ForeignKey("Drug")]
        public int DrugID { get; set; }
        public int Drugamount { get; set; }
        public int TotalPrice { get; set; }
        public DateTime DateofEntry { get; set; }
       // public int MyProperty { get; set; }
        public Supplier Supplier { get; set; }
        public Pharmacist pharmacist { get; set; }
        public List<Drug> Drugs { get; set; }



    }
}
