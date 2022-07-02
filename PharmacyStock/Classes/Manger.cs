using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyStock.Classes
{
    internal class Manger
    {
        [Key]
        public int Manger_ID { get; set; }

        [StringLength(20, MinimumLength = 3, ErrorMessage = "Use 3-20 characters")]
        public string Manger_Name { get; set; }
        [Phone]
        public int Manger_Phone { get; set; }


        public virtual Account Account { get; set; }
    }
}
