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
        public Nullable<int> AppointmentId { get; set; }

        [Required]
<<<<<<< HEAD
        public Nullable<System.DateTime> Date { get; set; }

        [Required]
        public Nullable<System.TimeSpan> FromTime { get; set; }

        [Required]
=======
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public Nullable<System.DateTime> Date { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh:mm tt}")]
        public Nullable<System.TimeSpan> FromTime { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh:mm tt}")]
>>>>>>> 7a8f3efc2ebed94cabd5cd1e061e876d2a8edce6
        public Nullable<System.TimeSpan> ToTime { get; set; }

        public Nullable<bool> IsCanceled { get; set; }
    }
}
