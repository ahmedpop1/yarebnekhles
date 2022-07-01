using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyStock.Classes
{
    internal class Pharmacist
    {
        [Key]
        public int ID { get; set; }
        public int BranchID { get; set; }
        public string Name { get; set; }
        public int MobileNumber { get; set; }

        public virtual List<SupplyBill> supplyBills { get; set; }
       
    }
}
