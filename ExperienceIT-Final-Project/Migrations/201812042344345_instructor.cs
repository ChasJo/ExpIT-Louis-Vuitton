namespace ExperienceIT_Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class instructor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mentors", "InstructorSubject", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mentors", "InstructorSubject");
        }
    }
}
