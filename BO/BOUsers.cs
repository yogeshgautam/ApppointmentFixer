using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class BOUsers
    {
        public string Id { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        [Compare("Email", ErrorMessage = "Email Mismatch")]
        public bool EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Compare("PhoneNumber", ErrorMessage = "Phone Number Mismatch")]
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }

        [Required]
        public string UserName { get; set; }
    }
}
