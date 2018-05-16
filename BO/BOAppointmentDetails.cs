using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class BOAppointmentDetails
    {
        public int Id { get; set; }
        public Nullable<int> DepartmentId { get; set; }


        [Required]
        public string AppointmentFrom { get; set; }

        [Required]

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh:mm tt}")]
        public string AppointmentFrom { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh:mm tt}")]

        public string AppointmentTo { get; set; }

        [Required]
        public Nullable<int> DateTimeId { get; set; }




        [Required]
        public string Details { get; set; }
<<<<<<< HEAD

=======
>>>>>>> bcc728bb558e224d7ad902b5f8d898ada0149495
        public string status { get; set; }
    }
}
