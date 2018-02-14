using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagmentHighSchool.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public int MarkListId { get; set; }
        public string CourseName { get; set; }

        public MarkList MarkList { get; set; }
    }
}