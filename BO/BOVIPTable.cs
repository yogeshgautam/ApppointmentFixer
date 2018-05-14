using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class BOVIPTable
    {
        public int Id { get; set; }

        [Required]
        public Nullable<int> DepartmentId { get; set; }
        public string UserId { get; set; }

        [Required]
        public string Designation { get; set; }
<<<<<<< HEAD

=======
>>>>>>> 7a8f3efc2ebed94cabd5cd1e061e876d2a8edce6
        [Required]
        public string Phone { get; set; }

        [Required]
<<<<<<< HEAD
        [EmailAddress]
        public string Email { get; set; }

=======
        public string Email { get; set; }
>>>>>>> 7a8f3efc2ebed94cabd5cd1e061e876d2a8edce6
        [Required]
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string Details { get; set; }

        [Required]
        public string FullName { get; set; }
        public string Photo { get; set; }
        public string CreatedAt { get; set; }
        public string LastUpdated { get; set; }

        [Required]
        public string Password { get; set; }

<<<<<<< HEAD
        [Compare("Password")]
=======
        [Required]
        [Compare("Password", ErrorMessage = "Password Mismatch")]
>>>>>>> 7a8f3efc2ebed94cabd5cd1e061e876d2a8edce6
        public string ConfirmPassword { get; set; }
        public BODepartment lstDepartment { get; set; }
    }
}
