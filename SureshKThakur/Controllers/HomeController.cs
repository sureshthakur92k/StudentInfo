﻿using SureshKThakur.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SureshKThakur.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EmployeeDBContext db = new EmployeeDBContext();
            List<Employee> obj = db.GetEmployee();
            return View(obj);
        }

        public ActionResult SaveEmp(String Name,String Address,String Salary)
        {
            EmployeeDBContext db = new EmployeeDBContext();
            bool result = db.SaveEmp(Name, Address, Salary);
            //return Json(result: result, JsonRequestBehavior.AllowGet);
            return new JsonResult()
            {
                Data = result,
                MaxJsonLength = Int32.MaxValue,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
        public ActionResult SaveStudentRegistration(Student student)
        {
            EmployeeDBContext db = new EmployeeDBContext();
            bool result = db.SaveStudentRegistration(student);
            //return Json(result: result, JsonRequestBehavior.AllowGet);
            return new JsonResult()
            {
                Data = result,
                MaxJsonLength = Int32.MaxValue,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
        public ActionResult CreateNewEmp()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult NewRegistration()
        {
            return View();
        }
        public ActionResult GetStudentClassName()
        {
            EmployeeDBContext db = new EmployeeDBContext();
            List<StudentClass> StdClassName = db.GetStudentClass();
            return Json(StdClassName, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetStateList()
        {
            EmployeeDBContext db = new EmployeeDBContext();
            List<Common> StateList = db.GetStateList();
            return Json(StateList, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetDistrictListByStateId(int StateId)
        {
            EmployeeDBContext db = new EmployeeDBContext();
            List<Common> StateList = db.GetDistrictByState(Convert.ToInt32(StateId));
            return Json(StateList, JsonRequestBehavior.AllowGet);
        }

    }
}