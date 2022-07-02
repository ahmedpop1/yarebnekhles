using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyStock.Classes
{
    internal class Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ID { get; set; }
       [Required]
       [StringLength(20, MinimumLength = 3, ErrorMessage = "Use 3-20 characters")]
        public string Name { get; set; }
        [Phone]
        public string Phone { get; set; }
        public virtual List<SupplyBill> supplyBills { get; set; }

    }
}
