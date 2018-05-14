using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class BOCompany
    {
        public int Id { get; set; }

<<<<<<< HEAD
        [Required]
        public string Name { get; set; }

=======
        [Required(ErrorMessage = " Company Name is Required")]
        [StringLength(3, ErrorMessage = "Name Must Be at least Three Characters")]
        public string Name { get; set; }
>>>>>>> 7a8f3efc2ebed94cabd5cd1e061e876d2a8edce6
        [Required]
        public string Address { get; set; }

        [Required]
        public string Photo { get; set; }
        public string UserId { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
<<<<<<< HEAD

        [Required]
        [EmailAddress]
=======
        [Required]
>>>>>>> 7a8f3efc2ebed94cabd5cd1e061e876d2a8edce6
        public string Email { get; set; }

        [Required]
        public string Description { get; set; }
        [Required]
        public string Phone { get; set; }
        public string CreatedAt { get; set; }
        public string LastUpdated { get; set; }
<<<<<<< HEAD


        [Required]
        public string password { get; set; }

        [Compare("password")]
=======
        [Required]
        public string password { get; set; }
        [Required]
        [Compare("password", ErrorMessage = "Password Mismatch")]
>>>>>>> 7a8f3efc2ebed94cabd5cd1e061e876d2a8edce6
        public string ConfirmPassword { get; set; }

        public BOCompany()
        {
            Photo = "default.png";
        }
    }
}
