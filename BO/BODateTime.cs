using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class BODateTime
    {
        public int Id { get; set; }

        public Nullable<System.DateTime> Date { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }
        public bool? IsCanceled { get; set; }
    }
}
