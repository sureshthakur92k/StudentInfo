using SureshKThakur.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SureshKThakur.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetStaffEduction()
        {
            EmployeeDBContext db = new EmployeeDBContext();
            List<Common> StateList = db.GetStaffEduction();
            return Json(StateList, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetStaffRole()
        {
            EmployeeDBContext db = new EmployeeDBContext();
            List<Common> StateList = db.GetStaffRole();
            return Json(StateList, JsonRequestBehavior.AllowGet);
        }
        public ActionResult SaveStaffRegistration(Student student)
        {
            EmployeeDBContext db = new EmployeeDBContext();
            bool result = db.SaveStaffRegistration(student);
            //return Json(result: result, JsonRequestBehavior.AllowGet);
            return new JsonResult()
            {
                Data = result,
                MaxJsonLength = Int32.MaxValue,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

    }
}