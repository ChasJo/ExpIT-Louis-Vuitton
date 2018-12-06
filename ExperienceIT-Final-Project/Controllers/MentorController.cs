using ExperienceIT_Final_Project.Models;
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
        private readonly object students;

        private ApplicationDbContext _context;

        public MentorController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Mentor
        public ActionResult Index()
        {
            // return View(students Progress<>);
            return View();
        }

        public ActionResult ViewStudents()
        {
            var students = _context.Students;
            return View(students);
        }

    }
}