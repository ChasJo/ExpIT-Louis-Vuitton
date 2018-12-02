using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExperienceIT_Final_Project.Models
{
    public class CompletedAssignment : Assignment
    {
       
        public int StudentID { get; set; }
        public string CompleteDate { get; set; }
        public string GitLink { get; set; }
    }
}