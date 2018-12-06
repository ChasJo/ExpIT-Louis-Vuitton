namespace ExperienceIT_Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAssignment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Assignments", "AssignmentNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Assignments", "AssignmentNumber");
        }
    }
}
