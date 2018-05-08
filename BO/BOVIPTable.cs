using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class BOVIPTable
    {
        public int Id { get; set; }
        public Nullable<int> DepartmentId { get; set; }

        public BODepartment lstDepartment { get; set; }
        public string Designation { get; set; }
        public string Contact { get; set; }

        public string UserId { get; set; }
       
        public string Address { get; set; }
        public string Details { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
