using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class BOCompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }
        public string UserId { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string CreatedAt { get; set; }
        public string LastUpdated { get; set; }

        public string password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
