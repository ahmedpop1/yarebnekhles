using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyStock.Classes
{
    internal class DrugWithExpiration
    {    [Key]
        public int ID { get; set; }

        [ForeignKey("Drug")]
        public int DrugID { get; set; }
        public Drug Drug { get; set; }
        public DateTime ManufacturingDate { get; set; }

        public DateTime ExpireDate { get; set; }
        //public List<DrugInSuppliedBill> SupplyBills { get; set; }
    }
}
