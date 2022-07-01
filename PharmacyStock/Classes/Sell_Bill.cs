using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    }
}
