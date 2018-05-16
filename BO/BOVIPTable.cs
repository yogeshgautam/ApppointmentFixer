﻿using System;
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

 
        public Nullable<int> DepartmentId { get; set; }
        public string UserId { get; set; }

     
        public string Designation { get; set; }

        [Required]
        public string Phone { get; set; }

    
        public string Email { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string Details { get; set; }

      
        public string FullName { get; set; }
        public string Photo { get; set; }
        public string CreatedAt { get; set; }
        public string LastUpdated { get; set; }

        public string Password { get; set; }

        
        public string ConfirmPassword { get; set; }
        public BODepartment lstDepartment { get; set; }
    }
}
