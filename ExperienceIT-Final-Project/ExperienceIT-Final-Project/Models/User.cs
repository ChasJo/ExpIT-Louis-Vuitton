using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExperienceIT_Final_Project.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        [Display(Name = "Enter Name")]
        public string Name { get; set; }


        //  public string Description { get; set; } 

        [Required]
        // [Display(username = "UserName")]
        public string Username { get; set; }
        public string Password { get; set; }


    }
}