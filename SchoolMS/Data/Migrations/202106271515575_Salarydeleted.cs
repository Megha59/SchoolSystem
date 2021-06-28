namespace SchoolMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Salarydeleted : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Schools", "Salary");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Schools", "Salary", c => c.Double(nullable: false));
        }
    }
}
