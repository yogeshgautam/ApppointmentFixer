using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class BODepartment
    {
        public int Id { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public string Name { get; set; }
        public string phone { get; set; }
        public string Email { get; set; }
        public string Details { get; set; }
        public string HOD { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string CreatedAt { get; set; }
        public string LastUpdated { get; set; }

        public BOCompany lstCompany { get; set; }
       
    }
}
