using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExperienceIT_Final_Project.Models
{
public class Assignments
{
    private int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int DueDate { get; set; }
    public string Url { get; set; }
}

}