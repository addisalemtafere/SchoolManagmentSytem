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
                        City = c.String(),
                        Kebele = c.String(),
                        HouseNumber = c.String(),
                        Email = c.String(),
                        Telephone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AddressId)
                .ForeignKey("dbo.Staffs", t => t.AddressId)
                .Index(t => t.AddressId);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Department = c.String(),
                        Salary = c.Double(nullable: false),
                        Gender = c.String(),
                        EmploymentDate = c.DateTime(nullable: false),
                        Qualification = c.String(),
                    })
                .PrimaryKey(t => t.TeacherId);
            
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
                        Address_TeacherId = c.Int(),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Staffs", t => t.Address_TeacherId)
                .Index(t => t.Address_TeacherId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Address_TeacherId", "dbo.Staffs");
            DropForeignKey("dbo.Addresses", "AddressId", "dbo.Staffs");
            DropIndex("dbo.Students", new[] { "Address_TeacherId" });
            DropIndex("dbo.Addresses", new[] { "AddressId" });
            DropTable("dbo.Students");
            DropTable("dbo.Staffs");
            DropTable("dbo.Addresses");
        }
    }
}
