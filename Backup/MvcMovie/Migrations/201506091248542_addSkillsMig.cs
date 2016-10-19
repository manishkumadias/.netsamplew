namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSkillsMig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Skill", c => c.String());
            DropColumn("dbo.Employees", "Skills");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Skills", c => c.String());
            DropColumn("dbo.Employees", "Skill");
        }
    }
}
