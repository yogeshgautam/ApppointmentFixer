using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class BODateTime
    {
        public int Id { get; set; }
<<<<<<< HEAD
        public Nullable<int> AppointmentId { get; set; }

        [Required]

        public Nullable<System.DateTime> Date { get; set; }

        [Required]
        public Nullable<System.TimeSpan> FromTime { get; set; }

        [Required]

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public Nullable<System.DateTime> Date { get; set; }

        [Required]
<<<<<<< HEAD
        public string FromTime { get; set; }

        [Required]
        public string ToTime { get; set; }

      
=======
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh:mm tt}")]
        public Nullable<System.TimeSpan> FromTime { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh:mm tt}")]

        public Nullable<System.TimeSpan> ToTime { get; set; }

>>>>>>> bcc728bb558e224d7ad902b5f8d898ada0149495
        public Nullable<bool> IsCanceled { get; set; }
=======

        public Nullable<System.DateTime> Date { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }
        public bool? IsCanceled { get; set; }
>>>>>>> diwasDevelopment
    }
}
