namespace ExperienceIT_Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateduser2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Email");
        }
    }
}
