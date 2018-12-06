using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExperienceIT_Final_Project.Controllers
{
    public class MentorController : Controller
    {
        //private readonly object students;


        // GET: Mentor
        public ActionResult Index()
        {
            // return View(students Progress<>);
            return View();
        }

        public ActionResult ViewStudents()
        {
            return View();
        }



    }
}