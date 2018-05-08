using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BO;

namespace BLL
{
    public class BLLAppointmentDetails
    {
        AppointmentDatabaseEntities _db = new AppointmentDatabaseEntities();
        public int CreateAppoointment(BOAppointmentDetails model)
        {
            tblAppointment appointment = new tblAppointment();
            appointment.AppointmentFrom = model.AppointmentFrom;
            appointment.AppointmentTo = model.AppointmentTo;
            appointment.DateTimeId = model.DateTimeId;
            appointment.DepartmentId = model.DepartmentId;
            appointment.Details = model.Details;
            _db.tblAppointments.Add(appointment);
            return _db.SaveChanges();
        }

        public int UpdateAppointment(BOAppointmentDetails model)
        {
            tblAppointment appointment = _db.tblAppointments.Where(u => u.Id == model.Id).FirstOrDefault();
            appointment.AppointmentFrom = model.AppointmentFrom;
            appointment.AppointmentTo = model.AppointmentTo;
            appointment.DateTimeId = model.DateTimeId;
            appointment.DepartmentId = model.DepartmentId;
            appointment.Details = model.Details;
            return _db.SaveChanges();
        }

        public List<BOAppointmentDetails> GetAllAppointment()
        {
            List<BOAppointmentDetails> lst = new List<BOAppointmentDetails>();
            var temp = _db.tblAppointments.ToList();
            foreach (var model in temp)
            {
                BOAppointmentDetails appointment = new BOAppointmentDetails();
                appointment.AppointmentFrom = model.AppointmentFrom;
                appointment.AppointmentTo = model.AppointmentTo;
                appointment.DateTimeId = model.DateTimeId;
                appointment.DepartmentId = model.DepartmentId;
                appointment.Details = model.Details;
                lst.Add(appointment);
            }
            return lst;
        }

        public int DeleteAppointment(int id)
        {
            tblAppointment appointment = _db.tblAppointments.Where(u => u.Id == id).FirstOrDefault();
            _db.tblAppointments.Remove(appointment);
            return _db.SaveChanges();
            
        }
    }
}
