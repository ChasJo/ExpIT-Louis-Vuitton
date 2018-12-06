namespace ExperienceIT_Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedcompletedassign : DbMigration
    {
        public override void Up()
        {
           // DropColumn("dbo.Assignments", "StudentID");
          //  DropColumn("dbo.Assignments", "CompleteDate");
          //  DropColumn("dbo.Assignments", "GitLink");
           // DropColumn("dbo.Assignments", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Assignments", "Discriminator", c => c.String(nullable: false, maxLength: 128));
          //  AddColumn("dbo.Assignments", "GitLink", c => c.String());
         ///   AddColumn("dbo.Assignments", "CompleteDate", c => c.String());
         //   AddColumn("dbo.Assignments", "StudentID", c => c.Int());
        }
    }
}
