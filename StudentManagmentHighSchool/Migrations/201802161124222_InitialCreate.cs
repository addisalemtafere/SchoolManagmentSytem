namespace StudentManagmentHighSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false),
                        Region = c.String(),
                        Ciity = c.String(),
                        kebele = c.String(),
                        Email = c.String(),
                        Telephone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AddressId)
                .ForeignKey("dbo.Staffs", t => t.AddressId)
                .ForeignKey("dbo.Students", t => t.AddressId)
                .Index(t => t.AddressId);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        StaffId = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Department = c.String(),
                        Salary = c.Double(nullable: false),
                        Gender = c.String(),
                        EmploymentDate = c.DateTime(nullable: false),
                        Qualification = c.String(),
                    })
                .PrimaryKey(t => t.StaffId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        PhotoUrl = c.String(),
                        Gender = c.Boolean(nullable: false),
                        ParentFirstName = c.String(),
                        ParentMiddleName = c.String(),
                        TelePhone = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId);
            
            CreateTable(
                "dbo.Admissions",
                c => new
                    {
                        AdmissionId = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        AdmitionYear = c.DateTime(nullable: false),
                        Grade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AdmissionId)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.MarkLists",
                c => new
                    {
                        MarkListId = c.Int(nullable: false, identity: true),
                        CourseId = c.Int(nullable: false),
                        AdmissionId = c.Int(nullable: false),
                        Mark = c.Single(nullable: false),
                        Semister = c.String(),
                    })
                .PrimaryKey(t => t.MarkListId)
                .ForeignKey("dbo.Admissions", t => t.AdmissionId, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.AdmissionId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        CourseName = c.String(),
                    })
                .PrimaryKey(t => t.CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Admissions", "StudentId", "dbo.Students");
            DropForeignKey("dbo.MarkLists", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.MarkLists", "AdmissionId", "dbo.Admissions");
            DropForeignKey("dbo.Addresses", "AddressId", "dbo.Students");
            DropForeignKey("dbo.Addresses", "AddressId", "dbo.Staffs");
            DropIndex("dbo.MarkLists", new[] { "AdmissionId" });
            DropIndex("dbo.MarkLists", new[] { "CourseId" });
            DropIndex("dbo.Admissions", new[] { "StudentId" });
            DropIndex("dbo.Addresses", new[] { "AddressId" });
            DropTable("dbo.Courses");
            DropTable("dbo.MarkLists");
            DropTable("dbo.Admissions");
            DropTable("dbo.Students");
            DropTable("dbo.Staffs");
            DropTable("dbo.Addresses");
        }
    }
}
