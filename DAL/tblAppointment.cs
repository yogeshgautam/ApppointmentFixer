//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblAppointment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblAppointment()
        {
            this.tblDateTimes = new HashSet<tblDateTime>();
        }
    
        public int Id { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public string AppointmentFrom { get; set; }
        public string AppointmentTo { get; set; }
        public Nullable<int> DateTimeId { get; set; }
        public string Details { get; set; }
    
        public virtual tblDateTime tblDateTime { get; set; }
        public virtual tblDepartment tblDepartment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDateTime> tblDateTimes { get; set; }
    }
}
