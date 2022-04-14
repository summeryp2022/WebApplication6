using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return Redirect(url: "https://www.google.com/");
        }
        public ActionResult Enter()
        {
            return View("EnterStudent");
        }
        public ActionResult Submit()
        {
            Student obj = new Student();
            obj.StudentRollNo = Request.Form["StudentRollNo"];
            obj.StudentName = Request.Form["StudentName"];
            obj.StudentStd = Request.Form["StudentStd"];
            obj.StudentDiv = Request.Form["StudentDiv"];
            return View("Student",obj);
           
        }
        public PartialViewResult Test()
        {
            return PartialView();
        }
    }
}