namespace ExperienceIT_Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentLastassignment2int : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "LastAssignment", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "LastAssignment", c => c.Int());
        }
    }
}
