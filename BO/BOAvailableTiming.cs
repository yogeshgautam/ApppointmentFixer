using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class BOAvailableTiming
    {
        public int Id { get; set; }
<<<<<<< HEAD


        [Required]
        public string Date { get; set; }

        [Required]
        public string StartTime { get; set; }

        [Required]
<<<<<<< HEAD
        public string EndTime { get; set; }
=======
        public Nullable<System.DateTime> Date { get; set; }
        [Required]
        public Nullable<System.TimeSpan> StartTime { get; set; }

        [Required]
        public Nullable<System.TimeSpan> EndTime { get; set; }
>>>>>>> bcc728bb558e224d7ad902b5f8d898ada0149495

        [Required]
=======
        public string Date { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
>>>>>>> diwasDevelopment
        public Nullable<bool> IsAvailable { get; set; }
        public Nullable<int> VipId { get; set; }
    }
}
