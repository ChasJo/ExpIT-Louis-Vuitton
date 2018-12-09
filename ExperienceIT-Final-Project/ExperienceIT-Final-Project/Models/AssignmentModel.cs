using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExperienceIT_Final_Project.Models
{
    public class AssignmentModel
    {
        public List<Assignment> AssignmentList { get; set; }
        public Student Student { get; set; }
    }
}