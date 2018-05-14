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
<<<<<<< HEAD

        [Required]
        public string AppointmentFrom { get; set; }

        [Required]
=======
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh:mm tt}")]
        public string AppointmentFrom { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh:mm tt}")]
>>>>>>> 7a8f3efc2ebed94cabd5cd1e061e876d2a8edce6
        public string AppointmentTo { get; set; }

        [Required]
        public Nullable<int> DateTimeId { get; set; }
<<<<<<< HEAD

=======
>>>>>>> 7a8f3efc2ebed94cabd5cd1e061e876d2a8edce6
        [Required]
        public string Details { get; set; }
    }
}
