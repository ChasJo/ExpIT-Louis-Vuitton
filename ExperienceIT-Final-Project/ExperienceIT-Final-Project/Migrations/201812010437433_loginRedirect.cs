namespace ExperienceIT_Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class loginRedirect : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mentors", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mentors", "Discriminator");
        }
    }
}
