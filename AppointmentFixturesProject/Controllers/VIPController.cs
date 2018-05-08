using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BO;
using BLL;
using Microsoft.AspNet.Identity;

namespace AppointmentFixturesProject.Controllers
{
    [Authorize(Roles = "COMPANYVIP")]
    public class VIPController : Controller
    {
        public static int VIPID = 0;
        BLLAvailableTiming blavailable = new BLLAvailableTiming();
        BLLVIP blvip = new BLLVIP();
        BLLCompany bllCompany = new BLLCompany();

        // GET: VIP
        BLLAvailableTiming available = new BLLAvailableTiming();


        public VIPController()
        {
            string id = System.Web.HttpContext.Current.User.Identity.GetUserId();
            var vip = blvip.GetAllVIP().Where(u => u.UserId == id).FirstOrDefault();
            VIPID = vip.Id;
        }
        public ActionResult Index()
        {
            BOVIPTable vip = blvip.GetVIPById(VIPID);
            return View(vip);
        }

        [HttpPost]
        public ActionResult Index(BOVIPTable model)
        {
            blvip.UpdateVIP(model);
            return View(model);
        }

        public ActionResult FixAppointment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FixAppointment(BOAvailableTiming model)
        {
            model.VipId= VIPID;
            available.AddAvailableTiming(model);
            return View();
        }

        public ActionResult ViewAppointment()
        {
            List<BOAvailableTiming> lst = blavailable.GetAvailableTimingByVIP(VIPID);
            return View(lst);
        }

        public ActionResult EditAppointmentTiming(int id)
        {
           
            return View();

        }

        public ActionResult DeleteAppointmentTiming(int id)
        {
            blavailable.DeleteAvailableTimings(id);
            return RedirectToAction("ViewAppointment");
        }
    }
}