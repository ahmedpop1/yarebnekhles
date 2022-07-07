using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyStock.Classes
{
    internal class DrugInSuppliedBill
    {
        [Key]
       [Column(Order = 0)]
        [ForeignKey("SuppliedBill")]
        public int BillID { get; set; }
       public  SupplyBill SuppliedBill { get; set; }
        [Key]
        [ForeignKey("Drugs")]
        [Column(Order = 1)]
        public int DrugWithExpirationID { get; set; }
        public  DrugWithExpiration Drugs { get; set; }

        public int Amount { get; set; }

      

    }
    //internal class SupplyBill1
    //{
        
    //    public SupplyBill SupplyBill { get; set; }
    //}


    }
