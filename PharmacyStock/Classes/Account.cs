using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyStock.Classes
{
    internal class Account
    {
        [Key]
        public String UserName { get; set; }

        public String Password { get; set; }

        public String User_Roll { get; set; }
        public String User_State { get; set; }
    }
}
