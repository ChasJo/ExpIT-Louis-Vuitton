namespace ExperienceIT_Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedAssignmentToStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "LastAssignment", c => c.Int(nullable: false));
            DropColumn("dbo.Students", "lastAssignment_Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "lastAssignment_Description", c => c.String());
            DropColumn("dbo.Students", "LastAssignment");
        }
    }
}
