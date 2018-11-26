using ExperienceIT_Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExperienceIT_Final_Project.Views.Student
{
    public class Student : User
    {
        public List<Assignments> assignmentList = new List<Assignments>();

        public Student() { }

        public void Submitassignment()
        {

        }
        public void Listassignment()
        {
        }

    }
}