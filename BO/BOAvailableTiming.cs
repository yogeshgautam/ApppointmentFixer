using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class BOAvailableTiming
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public Nullable<bool> IsAvailable { get; set; }
        public Nullable<int> VipId { get; set; }
    }
}
