  using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExperienceIT_Final_Project
{
    public abstract class User
    {
        [StringLength(60, MinimumLength = 3)]
        public int Id { get; set; }
        [Display(Name = "Enter Name")]
        public string Name{ get; set; }
        

        //  public string Description { get; set; } 

        [Required]
        // [Display(username = "UserName")]
        public string Username { get; set; }
        public string Password { get; set; }
        
            


    }
}