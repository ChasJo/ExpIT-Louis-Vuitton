using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExperienceIT_Final_Project
{
    public class Student : User
    {

        public List<Assignment> assignmentList = new List<Assignment>();

        public Student() { }

        public void Submitassignment()
        {

        }
        public void Listassignment()
        {
        }
    }
}