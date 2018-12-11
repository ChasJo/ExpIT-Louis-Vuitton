using ExperienceIT_Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
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

        [HttpPost]
        public ActionResult Save()
        {
            var student = _context.Students.Where(x => x.Email == User.Identity.Name).First();
            var studdentInDb = _context.Students.Single(c => c.Id == student.Id);
            studdentInDb.FirstName = student.FirstName;
            studdentInDb.LastName = student.LastName;
            studdentInDb.LastAssignment = student.LastAssignment+1;
            studdentInDb.Email = student.Email;

            Console.WriteLine("update assignment");

            _context.SaveChanges();
            return RedirectToAction("AllAssignments", "Student");
        }

        // GET: Student
        public ActionResult Index()
        {
            var student = _context.Students;

            return View(student);
        }

        public ActionResult AllAssignments()
        {
            var model = new AssignmentModel
            {
                AssignmentList = _context.Assignments.ToList(),
                Student = _context.Students.Where(x => x.Email == User.Identity.Name).First()
            };

            var compAssignments = _context.CompletedAssignments;

            
            return View(model);
        }
        public ActionResult Mentor()
        {
            var mentors = _context.Mentors;

            return View(mentors);
        }

        public ActionResult Details(int id)
        {
            var assign = _context.Assignments.SingleOrDefault(a => a.Id == id);

            return View(assign);
        }

 
    }
}