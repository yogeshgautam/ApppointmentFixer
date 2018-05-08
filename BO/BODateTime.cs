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
        public Nullable<int> AppointmentId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.TimeSpan> FromTime { get; set; }
        public Nullable<System.TimeSpan> ToTime { get; set; }
        public Nullable<bool> IsCanceled { get; set; }
    }
}
