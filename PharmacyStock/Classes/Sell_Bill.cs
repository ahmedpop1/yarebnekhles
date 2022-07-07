using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyStock.Classes
{
    internal class Sell_Bill
    {
        [Key]
        public int SellBill_ID { get; set; }
        public double Total_Price { get; set; }

        public string Customer_Name { get; set; }

        public DateTime date { get; set; }
        [ForeignKey("Pharmacist")]
        public int PharmacistID { get; set; }

        public virtual Pharmacist Pharmacist { get; set; }
    }

}
