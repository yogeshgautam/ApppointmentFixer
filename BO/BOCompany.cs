﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class BOCompany
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }

        public string Email { get; set; }

        public string password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
