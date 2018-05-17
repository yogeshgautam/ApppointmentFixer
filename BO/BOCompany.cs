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
       
=======

        
        


        [Required(ErrorMessage = " Company Name is Required")]
        [StringLength(3, ErrorMessage = "Name Must Be at least Three Characters")]
>>>>>>> a6e5fc65e27473bca30aedff8c6f742c84974d8f
        public string Name { get; set; }

     
        public string Address { get; set; }

     
        public string Photo { get; set; }
        public string UserId { get; set; }
        public Nullable<bool> IsDeleted { get; set; }


<<<<<<< HEAD
=======
        [Required]
        [EmailAddress]

        [Required]

>>>>>>> a6e5fc65e27473bca30aedff8c6f742c84974d8f
        public string Email { get; set; }


        public string Description { get; set; }
<<<<<<< HEAD

=======
>>>>>>> f56b9ffbdf8c6804509719b4d0e152cacc57b353
        [Required]
        public string Phone { get; set; }
        public string CreatedAt { get; set; }
        public string LastUpdated { get; set; }


<<<<<<< HEAD
 
        public string password { get; set; }

      
=======

        [Required]
        public string password { get; set; }

        [Compare("password")]

        [Required]
        public string password { get; set; }
        [Required]
        [Compare("password", ErrorMessage = "Password Mismatch")]

>>>>>>> a6e5fc65e27473bca30aedff8c6f742c84974d8f
        public string ConfirmPassword { get; set; }

        public BOCompany()
        {
            Photo = "default.png";
        }
    }
}
