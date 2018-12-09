using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExperienceIT_Final_Project.Models
{
    public class CompletedAssignment 
    {
        public int Id { get; set; }
        public string DueDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int StudentId { get; set; }
        public string CompleteDate { get; set; }
        public string GitLink { get; set; }
    }
}