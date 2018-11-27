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
            var assignmentsA = new Assignments() { Name = "Module A", Url = "https://docs.google.com/document/d/1ycp4FkvOyqjUfpXYJ18GZnGFw5OcjGD5nmhUEthJOgQ/edit"};
            var assignmentsB = new Assignments() { Name = "Module B", Url = "https://docs.google.com/document/d/1FtrJw3JOTcxbuCWFJzxRReLFvuNq5TXZIC5hhnm-rYw/edit" };
            var assignmentsC = new Assignments() { Name = "Module C"};
            var assignmentsD = new Assignments() { Name = "Module D"};
            var assignmentsE = new Assignments() { Name = "Module E"};
            var assignmentsF = new Assignments() { Name = "Module F"};

            var Assignments = new List<Assignments>();
            Assignments.Add(assignmentsA);
            Assignments.Add(assignmentsB);
            Assignments.Add(assignmentsC);
            Assignments.Add(assignmentsD);
            Assignments.Add(assignmentsE);
            Assignments.Add(assignmentsF);

            ViewBag.Assignments = Assignments;

            return View();
        }
    }
}