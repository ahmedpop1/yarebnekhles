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

        public string Manger_Name { get; set; }

        public int Manger_Phone { get; set; }


        public virtual Account Account { get; set; }
    }
}
