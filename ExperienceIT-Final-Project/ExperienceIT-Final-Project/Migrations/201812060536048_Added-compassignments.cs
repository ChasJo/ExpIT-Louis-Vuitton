namespace ExperienceIT_Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedcompassignments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CompletedAssignments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DueDate = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                        StudentID = c.Int(nullable: false),
                        CompleteDate = c.String(),
                        GitLink = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CompletedAssignments");
        }
    }
}
