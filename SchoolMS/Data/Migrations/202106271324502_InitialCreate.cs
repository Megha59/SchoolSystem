namespace SchoolMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Department_Id = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => new { t.Id, t.Department_Id })
                .ForeignKey("dbo.Departments", t => t.Id, cascadeDelete: true)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        School_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Schools", t => t.School_Id)
                .Index(t => t.School_Id);
            
            CreateTable(
                "dbo.Registrations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fees = c.Double(nullable: false),
                        School_Id = c.Int(nullable: false),
                        School_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Schools", t => t.School_Id1)
                .Index(t => t.School_Id1);
            
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Salary = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Post_Name = c.String(),
                        Address = c.String(),
                        Salary = c.Double(nullable: false),
                        School_Id = c.Int(nullable: false),
                        School_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Schools", t => t.School_Id1)
                .Index(t => t.School_Id1);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Registration_Id = c.Int(nullable: false),
                        Registration_Id1 = c.Int(),
                        School_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Registrations", t => t.Registration_Id1)
                .ForeignKey("dbo.Schools", t => t.School_Id)
                .Index(t => t.Registration_Id1)
                .Index(t => t.School_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "School_Id", "dbo.Schools");
            DropForeignKey("dbo.Students", "Registration_Id1", "dbo.Registrations");
            DropForeignKey("dbo.Staffs", "School_Id1", "dbo.Schools");
            DropForeignKey("dbo.Registrations", "School_Id1", "dbo.Schools");
            DropForeignKey("dbo.Departments", "School_Id", "dbo.Schools");
            DropForeignKey("dbo.Courses", "Id", "dbo.Departments");
            DropIndex("dbo.Students", new[] { "School_Id" });
            DropIndex("dbo.Students", new[] { "Registration_Id1" });
            DropIndex("dbo.Staffs", new[] { "School_Id1" });
            DropIndex("dbo.Registrations", new[] { "School_Id1" });
            DropIndex("dbo.Departments", new[] { "School_Id" });
            DropIndex("dbo.Courses", new[] { "Id" });
            DropTable("dbo.Students");
            DropTable("dbo.Staffs");
            DropTable("dbo.Schools");
            DropTable("dbo.Registrations");
            DropTable("dbo.Departments");
            DropTable("dbo.Courses");
        }
    }
}
