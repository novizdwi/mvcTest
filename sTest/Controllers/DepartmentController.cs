using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections;
using sTest.Models;

namespace sTest.Controllers
{
    public class DepartmentController : Controller
    {

        public ActionResult DepartmentList() {
            var Department = new department();
            ViewBag.Heading = "Department List";
            
            return View(Department);
        }

        // GET: Department
        public ActionResult Index()
        {
            return View();
        }
    }
}