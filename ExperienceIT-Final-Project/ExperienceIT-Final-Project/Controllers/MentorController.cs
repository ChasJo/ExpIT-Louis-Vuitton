﻿using ExperienceIT_Final_Project.Models;
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

        private ApplicationDbContext _context;
        //private readonly object students;
        public MentorController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Mentor
        public ActionResult Index()
        {
            /*
            var model = new AssignmentModel
            {
                AssignmentList = _context.Assignments.ToList(),
                Student = _context.Students.Where(x => x.Email == User.Identity.Name).First()
            };
            return View(model);
            */
            var student = _context.Students;
            return View(student);
        }


    }
}