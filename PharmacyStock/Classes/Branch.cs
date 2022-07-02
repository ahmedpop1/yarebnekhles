using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyStock.Classes
{
    internal class Branch
    {
        [Key]
        public int Branch_ID { get; set; }

        public string Branch_Name { get; set; }

        public string Branch_Address { get; set; }


        public ICollection<Pharmacist> Pharmacists { get; set; }
       // public ICollection<Branch> branchess { get; set; }

        //public List<Stored_Drug> Stored_Drug { get; set; }


    }
}
