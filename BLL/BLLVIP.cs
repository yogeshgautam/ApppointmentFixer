using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;


namespace BLL
{
    public class BLLVIP
    {
        AppointmentDatabaseEntities _db = new AppointmentDatabaseEntities();
        BLLDepartment bldepartment = new BLLDepartment();
        public int CreateVIP(BOVIPTable model)
        {
            tblVIPUser vip = new tblVIPUser();
            vip.DepartmentId = model.DepartmentId;
            vip.Designation = model.Designation;
            vip.UserId = model.UserId;
            vip.Contact = model.Contact;
            vip.Email = model.Email;
            vip.Address = model.Address;
            vip.Details = model.Details;
            vip.IsDeleted = false;
            _db.tblVIPUsers.Add(vip);
            return _db.SaveChanges();            
        }

        public int UpdateVIP(BOVIPTable model)
        {
            tblVIPUser vip = _db.tblVIPUsers.Where(u => u.Id == model.Id).FirstOrDefault();
            vip.DepartmentId = model.DepartmentId;
            vip.Designation = model.Designation;
            vip.Contact = model.Contact;
            vip.Email = model.Email;
            vip.Address = model.Address;
            vip.Details = model.Details;
          //  vip.UserId = model.UserId;
            return _db.SaveChanges();
        }

        public List<BOVIPTable> GetAllVIP()
        {
            List<BOVIPTable> lst = new List<BOVIPTable>();
            var temp = _db.tblVIPUsers.Where(u=>u.IsDeleted==false).ToList();
            foreach (var model in temp)
            {
                BOVIPTable vip = new BOVIPTable();
                vip.Id = model.Id;
                vip.lstDepartment = bldepartment.GetDepartmentById(model.DepartmentId.Value);
                vip.DepartmentId = model.DepartmentId;
                vip.Designation = model.Designation;
                vip.UserId = model.UserId;
                vip.Contact = model.Contact;
                vip.Email = model.Email;
                vip.Address = model.Address;
                vip.Details = model.Details;
                vip.Id = model.Id;
                lst.Add(vip);
            }
            return lst;
        }

        public BOVIPTable GetVIPById(int id)
        {
            tblVIPUser model = _db.tblVIPUsers.Where(u => u.Id == id&&u.IsDeleted==false).FirstOrDefault();
            BOVIPTable vip = new BOVIPTable();
            vip.Id = model.Id;
            vip.DepartmentId = model.DepartmentId;
            vip.lstDepartment = bldepartment.GetDepartmentById(model.DepartmentId.Value);
            vip.Designation = model.Designation;
            vip.UserId = model.UserId;
            vip.Contact = model.Contact;
            vip.Email = model.Email;
            vip.Address = model.Address;
            vip.Details = model.Details;
            return vip;
        }

        public int DeleteVIP(int id)
        {
            tblVIPUser vip = _db.tblVIPUsers.Where(u => u.Id == id).FirstOrDefault();
            vip.IsDeleted = true;
            //_db.tblVIPUsers.Remove(vip);
            return _db.SaveChanges();
        }
    }
}
