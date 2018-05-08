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

        public BOCompany lstCompany { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
    }
}
