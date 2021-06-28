namespace SchoolMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Regiddeleted : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Students", new[] { "Registration_Id1" });
            DropColumn("dbo.Students", "Registration_Id");
            RenameColumn(table: "dbo.Students", name: "Registration_Id1", newName: "Registration_Id");
            AlterColumn("dbo.Students", "Registration_Id", c => c.Int());
            CreateIndex("dbo.Students", "Registration_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Students", new[] { "Registration_Id" });
            AlterColumn("dbo.Students", "Registration_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Students", name: "Registration_Id", newName: "Registration_Id1");
            AddColumn("dbo.Students", "Registration_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "Registration_Id1");
        }
    }
}
