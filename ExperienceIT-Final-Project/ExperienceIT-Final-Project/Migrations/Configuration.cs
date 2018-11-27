namespace ExperienceIT_Final_Project.Migrations
{
    using ExperienceIT_Final_Project.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ExperienceIT_Final_Project.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ExperienceIT_Final_Project.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            
            context.Students.Add(new Student { Name = "a", Password = "a", Username = "a", LastAssignment = 0});
            context.Assignments.Add(new Assignment { Id = 0, DueDate = "11/1/18", Name = "Assignment 1", Description = "This is a test" });
            context.Mentors.Add( new Mentor { Id = 1, FirstName ="Rich", LastName =" ", Email="something@yahoo.com", PhoneNumber= "5555555555" } );
        }
    }
}
