using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExperienceIT_Final_Project.Models
{
    public class Student : User
    {
        public int LastAssignment { get; set; }


        public List<Assignment> assignmentList = new List<Assignment>();

        public Student() {
            
        }

        public void Submitassignment()
        {

        }
        public void Listassignment()
        {
        }

    }
}