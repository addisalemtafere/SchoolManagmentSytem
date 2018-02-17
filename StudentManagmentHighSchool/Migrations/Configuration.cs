using StudentManagmentHighSchool.Models;

namespace StudentManagmentHighSchool.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class
        Configuration : DbMigrationsConfiguration<StudentManagmentHighSchool.Context.SchoolStudentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "StudentManagmentHighSchool.Context.SchoolStudentContext";
        }

        protected override void Seed(StudentManagmentHighSchool.Context.SchoolStudentContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Students.AddOrUpdate(
                new Student
                {
                    FirstName = "Adonay",
                    MiddleName = "Addisalem",
                    LastName = "Tafer",
                    BirthDate = DateTime.Now,
                    PhotoUrl = "Url",
                    Gender = true,
                    ParentFirstName = "addisalem",
                    ParentMiddleName = "Tafere",
                    TelePhone = 09201729176
                },
                new Student
                {
                    FirstName = "Adonay",
                    MiddleName = "Addisalem",
                    LastName = "Tafer",
                    BirthDate = DateTime.Now,
                    PhotoUrl = "Url",
                    Gender = true,
                    ParentFirstName = "addisalem",
                    ParentMiddleName = "Tafere",
                    TelePhone = 09201729176
                },
                new Student
                {
                    FirstName = "Adonay",
                    MiddleName = "Addisalem",
                    LastName = "Tafer",
                    BirthDate = DateTime.Now,
                    PhotoUrl = "Url",
                    Gender = true,
                    ParentFirstName = "addisalem",
                    ParentMiddleName = "Tafere",
                    TelePhone = 09201729176
                },
                new Student
                {
                    FirstName = "Adonay",
                    MiddleName = "Addisalem",
                    LastName = "Tafer",
                    BirthDate = DateTime.Now,
                    PhotoUrl = "Url",
                    Gender = true,
                    ParentFirstName = "addisalem",
                    ParentMiddleName = "Tafere",
                    TelePhone = 09201729176
                },
                new Student
                {
                    FirstName = "Adonay",
                    MiddleName = "Addisalem",
                    LastName = "Tafer",
                    BirthDate = DateTime.Now,
                    PhotoUrl = "Url",
                    Gender = true,
                    ParentFirstName = "addisalem",
                    ParentMiddleName = "Tafere",
                    TelePhone = 09201729176
                },
                new Student
                {
                    FirstName = "Adonay",
                    MiddleName = "Addisalem",
                    LastName = "Tafer",
                    BirthDate = DateTime.Now,
                    PhotoUrl = "Url",
                    Gender = true,
                    ParentFirstName = "addisalem",
                    ParentMiddleName = "Tafere",
                    TelePhone = 09201729176
                }
            );
            context.Staffs.AddOrUpdate(
                new Staff
                {
                    Firstname = "Mebri",
                    MiddleName = "Hailay",
                    LastName = "Abrha",
                    Department = "Computer",
                    EmploymentDate = DateTime.Now,
                    Gender = "female",
                    Qualification = "master",
                    Salary = 12000
                },
            new Staff
            {
                Firstname = "Mebri",
                MiddleName = "Hailay",
                LastName = "Abrha",
                Department = "Computer",
                EmploymentDate = DateTime.Now,
                Gender = "female",
                Qualification = "master",
                Salary = 12000
            },
            new Staff
            {
                Firstname = "Mebri",
                MiddleName = "Hailay",
                LastName = "Abrha",
                Department = "Computer",
                EmploymentDate = DateTime.Now,
                Gender = "female",
                Qualification = "master",
                Salary = 12000
            },
            new Staff
            {
                Firstname = "Mebri",
                MiddleName = "Hailay",
                LastName = "Abrha",
                Department = "Computer",
                EmploymentDate = DateTime.Now,
                Gender = "female",
                Qualification = "master",
                Salary = 12000
            });
        }
    }
}