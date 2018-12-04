namespace ExperienceIT_Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class madeCompleteAssignment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Assignments", "StudentID", c => c.Int());
            AddColumn("dbo.Assignments", "CompleteDate", c => c.String());
            AddColumn("dbo.Assignments", "GitLink", c => c.String());
            
        }
        
        public override void Down()
        {
           
            DropColumn("dbo.Assignments", "GitLink");
            DropColumn("dbo.Assignments", "CompleteDate");
            DropColumn("dbo.Assignments", "StudentID");
        }
    }
}
