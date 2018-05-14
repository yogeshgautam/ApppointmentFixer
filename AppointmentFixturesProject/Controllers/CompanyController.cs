using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BO;
using BLL;
using Microsoft.AspNet.Identity;
using System.Web.Security;
using System.Net;

//


namespace AppointmentFixturesProject.Controllers
{

    [Authorize(Roles = "CompanyMaster")]
    public class CompanyController : Controller
    {
        //temp code


        BLLDepartment bllDepartment = new BLLDepartment();
        BLLCompany bllCompany = new BLLCompany();
        BLLVIP bllvip = new BLLVIP();
        BLLUser bluser = new BLLUser();
        BLLAvailableTiming blavailable = new BLLAvailableTiming();
        BLLAppointmentDetails bllAppointment = new BLLAppointmentDetails();
        BLLDateTime bllDateTime = new BLLDateTime();

        public static int companyId = 1;
        public static string companyName = "";


        public CompanyController()
        {

            string id = System.Web.HttpContext.Current.User.Identity.GetUserId();
            var lst = bllCompany.GetAllCompany().Where(u => u.UserId == id).FirstOrDefault();
            companyId = lst.Id;
            companyName = lst.Name;
        }


        //this method is called to get the application name in the navigation bar
        public string CompanyName()
        {
            string id = User.Identity.GetUserId();
            var lst = bllCompany.GetAllCompany().Where(u => u.UserId == id).FirstOrDefault();
            companyId = lst.Id;
            companyName = lst.Name;
            return lst.Name;
        }

        public ActionResult partialComanyName()
        {
            return PartialView("_CompanyNamePartial", companyName);
        }

        // GET: Company
        public ActionResult Index()
        {
            List<BODepartment> lst = bllDepartment.GetAllDepartment().Where(u => u.CompanyId == companyId).ToList();
            return View(lst);
        }

        public ActionResult CreateDepartment()
        {

            return View();
        }

        [HttpPost]
        public ActionResult CreateDepartment(BODepartment model)
        {
            model.CompanyId = companyId;
            if (bllDepartment.CreateDepartment(model) == 1)
            {
                ViewBag.Message = "Department Created Successfully";
            }
            else
            {
                ViewBag.Message = "There was a problem Creating Department. Please Contact Administrator for Support.";
            }

            return View();
        }

        public ActionResult VIP()
        {
            List<BOVIPTable> lst = bllvip.GetAllVIP().Where(u => u.lstDepartment.CompanyId == companyId).ToList();
            return View(lst);
        }

        public ActionResult CreateVIP()
        {
            var x = bllDepartment.GetAllDepartment().Where(u => u.CompanyId == companyId).ToList();
            ViewBag.Department = x;

            var y = bluser.GetAllUsers();
            ViewBag.Users = y;

            return View();
        }
        [HttpPost]
        public ActionResult CreateVIP(BOVIPTable model)
        {

            if (bllvip.CreateVIP(model) == 1)
            {
                Roles.RemoveUserFromRole(model.Email, "CompanyMaster");
                Roles.AddUserToRole(model.Email, "COMPANYVIP");
                //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
                //RedirectToAction("CreateVIP", "MyAccountController", new { model = model });
                //AccountController ac = new AccountController();
                //string userid=User.Identity.GetUserId();   
                //var roleresult =ac.UserManager.AddToRole(model.UserId, "CompanyMaster");
                ViewBag.Message = "VIP Created Success ! ";
                //Roles.AddUsersToRole(User.Identity., "CompanyMaster");

            }
            else
            {
                ViewBag.Message = "There was a problem creating VIP. Please contact Administrator for details. ";
            }

            ViewBag.Department = bllDepartment.GetAllDepartment().Where(u => u.CompanyId == companyId).ToList();
            var y = bluser.GetAllUsers();
            ViewBag.Users = y;
            return View();
        }

        public ActionResult DeleteVIP(int id)
        {
            BOVIPTable model = bllvip.GetVIPById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult DeleteVIP(BOVIPTable model)
        {
            bllvip.DeleteVIP(model.Id);
            return RedirectToAction("VIP");
        }

        public ActionResult EditVIP(int id)
        {
            BOVIPTable vip = bllvip.GetVIPById(id);
            ViewBag.Department = bllDepartment.GetAllDepartment();
            return View(vip);
        }

        [HttpPost]
        public ActionResult EditVIP(BOVIPTable model)
        {
            bllvip.UpdateVIP(model);
            ViewBag.Department = bllDepartment.GetAllDepartment();
            return RedirectToAction("VIP");
        }

        public ActionResult DetailsVIP(int id)
        {
            BOVIPTable vip = bllvip.GetVIPById(id);
            return View(vip);
        }

        //for departments 
        public ActionResult EditDepartment(int id)
        {
            BODepartment model = bllDepartment.GetDepartmentById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult EditDepartment(BODepartment model)
        {


            bllDepartment.UpdateDepartment(model);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteDepartment(int id)
        {
            BODepartment model = bllDepartment.GetDepartmentById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult DeleteDepartment(BODepartment model)
        {
            bllDepartment.DeleteDepartment(model.Id);
            return RedirectToAction("Index");
        }

        public ActionResult DetailsDepartment(int id)
        {
            BODepartment model = bllDepartment.GetDepartmentById(id);
            return View(model);
        }

        public ActionResult ScheduleVip(int id)
        {
            List<BOAvailableTiming> lst = blavailable.GetAvailableTimingByVIP(id);
            return View(lst);

        }

        public ActionResult FixAppointment()
        {
            List<BOVipViewModel> lst = bllAppointment.GetAllStaffAppointmentDetails();
            return View(lst);
        }

        public ActionResult EditAppointment(int id)
        {
            var temp = bllDateTime.GetAllDateTime().Where(u => u.Id == id).SingleOrDefault();
            return View(temp);
        }


        [HttpPost]
        public ActionResult EditAppointment(BODateTime modal)
        {
            if (ModelState.IsValid)
            {

                var tmp = bllDateTime.UpdateDateTime(modal);
                if (tmp > 0)
                {
                    return RedirectToAction("FixAppointment");
                }
                else
                {
                    ViewBag.Appointment = "Failed To Edit";
                    return View();
                }
                   
            }
            else
            {
                ViewBag.Appointment = "Failed To Edit";
                return View();
            }
        }

        public ActionResult DeleteAppointment(int id)
        {
            var temp = bllDateTime.GetAllDateTime().Where(u => u.Id == id).SingleOrDefault();
            return View(temp);

        }

        [HttpPost]
        public ActionResult DeleteAppointment(BOVipViewModel model)
        {
            return View();
        }

    }
}