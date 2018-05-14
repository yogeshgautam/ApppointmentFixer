
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using BO;
using DAL;

namespace BLL
{
   public class BLLMeetingFirst
    {
        AppointmentDatabaseEntities2 _db = new AppointmentDatabaseEntities2();
        BLLVIP blvip = new BLLVIP();
        public int AddMeetingFirst(BOMeetingFirst model)
        {
            tblMeetingFirst meeting = new tblMeetingFirst();
            meeting.VIPuser = model.VIPuser;
            meeting.Users = model.Users;
            meeting.StartTime = model.StartTime;
            meeting.EndTime = model.EndTime;
            meeting.Date = model.Date;
            _db.tblMeetingFirsts.Add(meeting);
            return _db.SaveChanges();
        }
        public int UpdateMeetingOne(BOMeetingFirst model)
        {
            tblMeetingFirst meeting = _db.tblMeetingFirsts.Where(u => u.ID == model.ID).FirstOrDefault();
            meeting.VIPuser = model.VIPuser;
            meeting.Users = model.Users;
            meeting.StartTime = model.StartTime;
            meeting.EndTime = model.EndTime;
            meeting.Date = model.Date;

            return _db.SaveChanges();
        }
        public List<BOMeetingFirst> GetALLMeeting()
        {
            List<BOMeetingFirst> lst = new List<BOMeetingFirst>();
            var ls = _db.tblMeetingFirsts.ToList();
            
            foreach (var item in ls)
            {
                lst.Add(new BOMeetingFirst() { ID = item.ID, VIPuser = item.VIPuser,Users = item.Users, StartTime = item.StartTime, EndTime = item.EndTime, Date = item.Date });
                    

            }
            
            return lst;
        }
        public BOMeetingFirst GetALLMeetingByID(int id)
        {
            var ls = _db.tblMeetingFirsts.Where(u => u.ID == id).FirstOrDefault();
            BOMeetingFirst ave = new BOMeetingFirst() { ID = ls.ID, VIPuser = ls.VIPuser, Users = ls.Users, StartTime = ls.StartTime, EndTime = ls.EndTime, Date = ls.Date };
            return ave;

        }


        public int DeleteMeeting (int id)
        {
            tblMeetingFirst tb = _db.tblMeetingFirsts.Where(u => u.ID == id).FirstOrDefault();
            _db.tblMeetingFirsts.Remove(tb);
            return _db.SaveChanges();
        }
    }
}

