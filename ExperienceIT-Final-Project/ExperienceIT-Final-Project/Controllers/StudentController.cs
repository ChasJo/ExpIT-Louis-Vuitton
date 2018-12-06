using ExperienceIT_Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExperienceIT_Final_Project.Controllers
{
    public class StudentController : Controller
    {

        private ApplicationDbContext _context;
        
        public StudentController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Student
        public ActionResult Index()
        {
            var student = _context.Students;

            return View(student);
        }

        public ActionResult AllAssignments(int)
        {
            var student = _context.Students;
            var assignments = _context.Assignments;
            var compAssignments = _context.CompletedAssignments;

            
            return View(assignments);
        }
        public ActionResult Mentor()
        {
            var mentors = _context.Mentors;

            return View(mentors);
        }

    }
}