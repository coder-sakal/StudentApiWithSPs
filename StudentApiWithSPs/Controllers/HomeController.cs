using StudentApiWithSPs.DTO;
using StudentApiWithSPs.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentApiWithSPs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            Student s = new Student();
            s.Name = "Parth";
            s.Gender = 1;
           
            s.IsHandicap = false;
            s.Standerd = 34;
            s.Save(); 

            return View();
        }
    }
}
