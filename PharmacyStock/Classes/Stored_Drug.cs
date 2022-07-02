using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyStock.Classes
{
    internal class Stored_Drug
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("Branch")]
        public int Branch_ID { get; set; }
        public Branch Branch { get; set; }
        [Key]
        [ForeignKey("Drugs")]
        [Column(Order = 1)]
        public int DrugWithExpirationID { get; set; }
        public DrugWithExpiration Drugs { get; set; }


        public int Quantity_Exist { get; set; }
       // public ICollection<Branch> Branches { get; set; }
        //public List<Branch1> Branches2 { get; set; }

    }
    //internal class Branch1 {
    //    public Branch MyProperty { get; set; }
       
    //}
}
