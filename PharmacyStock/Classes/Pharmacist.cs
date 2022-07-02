using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyStock.Classes
{
    internal class Pharmacist
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ID { get; set; }

        public int BranchID { get; set; }

        [Required]
        public string Name { get; set; }
        
        public string MobileNumber { get; set; }

        [ForeignKey("Branch")]
        public int Branch_ID { get; set; }

        public Branch Branch { get; set; }

        public virtual List<SupplyBill> supplyBills { get; set; }

        public virtual Account Accounts { get; set; }






    }
}
