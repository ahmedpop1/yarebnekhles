using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyStock.Classes
{
    internal class DrugIn_SoldBill
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("Sell_Bill")]
        public int SellBill_ID { get; set; }
        public Sell_Bill Sell_Bill { get; set; }
        [Key]
        [ForeignKey("Drugs")]
        [Column(Order = 1)]
        public int DrugWithExpirationID { get; set; }
        public DrugWithExpiration Drugs { get; set; }


        public int Amount { get; set; }

    }
}
