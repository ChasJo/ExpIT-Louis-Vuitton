using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExperienceIT_Final_Project.Models;

namespace ExperienceIT_Final_Project.Controllers
{
    public class AssignmentsController : Controller
    {
        // GET: Assignments
        public ActionResult Index()
        {

            return View();
        }
    }
}