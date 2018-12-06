namespace ExperienceIT_Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class instructorremoved : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Mentors", "InstructorSubject");
            //DropColumn("dbo.Mentors", "Discriminator");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.Mentors", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Mentors", "InstructorSubject", c => c.String());
        }
    }
}
