using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace PharmacyStock.Classes
{
    internal class Account
    {
        [Key]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Use 3-20 characters")]
        public String UserName { get; set; }

        [MembershipPassword(
        MinRequiredPasswordLength = 8,
        ErrorMessage = "Your password needs to be at least 8 characters long",
        MinRequiredNonAlphanumericCharacters = 1,
        MinNonAlphanumericCharactersError = "At least one of the characters needs to be non-alphanumeric")]
        public int Password { get; set; }
    }
}
