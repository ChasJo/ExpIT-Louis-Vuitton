namespace ExperienceIT_Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "LastAssignmentCompleted");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "LastAssignmentCompleted", c => c.String());
        }
    }
}
