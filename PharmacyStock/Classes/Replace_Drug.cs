using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyStock.Classes
{
    internal class Replace_Drug
    {
            
        //[Key]
        //[Column(Order = 0)]
        //[ForeignKey("Stored_Drug")]
        //public int StoredDrug_ID { get; set; }
        //public Stored_Drug Stored_Drug { get; set; }

        [Key]
        [Column(Order = 0)]
        [ForeignKey("Branch_From")]
        public int Replace_From { get; set; }
         public Branch Branch_From { get; set; }

        [Key]
        [Column(Order = 1)]
        [ForeignKey("Branch_To")]
        public int Replace_To { get; set; }
        public Branch Branch_To { get; set; }

    }
}
