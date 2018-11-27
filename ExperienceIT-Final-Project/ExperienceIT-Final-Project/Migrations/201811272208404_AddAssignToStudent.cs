namespace ExperienceIT_Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAssignToStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "lastAssignment_Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "lastAssignment_Description");
        }
    }
}
