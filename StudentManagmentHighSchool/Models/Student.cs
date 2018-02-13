using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagmentHighSchool.Models
{
    public class Student
    {

        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string PhotoUrl { get; set; }

        public bool Gender { get; set; }

        public string ParentFirstName { get; set; }

        public string ParentMiddleName { get; set; }

        public long TelePhone { get; set; }

        public  Address Address { get; set; }

    }
}