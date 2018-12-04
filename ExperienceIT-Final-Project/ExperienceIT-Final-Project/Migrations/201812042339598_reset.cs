namespace ExperienceIT_Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reset : DbMigration
    {
        public override void Up()
        {
        }
        
        public override void Down()
        {
            
            AddColumn("dbo.Mentors", "Discriminator", c => c.String());
        }
    }
}
