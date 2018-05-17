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



        
        


        [Required(ErrorMessage = " Company Name is Required")]
        [StringLength(3, ErrorMessage = "Name Must Be at least Three Characters")]

        public string Name { get; set; }

     
        public string Address { get; set; }

     
        public string Photo { get; set; }
        public string UserId { get; set; }
        public Nullable<bool> IsDeleted { get; set; }



        [Required]
        [EmailAddress]

        [Required]


        public string Email { get; set; }


        public string Description { get; set; }

        [Required]
        public string Phone { get; set; }
        public string CreatedAt { get; set; }
        public string LastUpdated { get; set; }



 
        public string password { get; set; }

      


        [Required]
        public string password { get; set; }

        [Compare("password")]

        [Required]
        public string password { get; set; }
        [Required]
        [Compare("password", ErrorMessage = "Password Mismatch")]


        public string ConfirmPassword { get; set; }

        public BOCompany()
        {
            Photo = "default.png";
        }
    }
}
