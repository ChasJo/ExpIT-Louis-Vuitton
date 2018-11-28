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
            //var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View();
        }

        public ActionResult AllAssignments()
        {
            // var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View();
        }
        public ActionResult Mentor()
        {
            var mentors = _context.Mentors;

            return View(mentors);
        }

    }
}