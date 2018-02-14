﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentManagmentHighSchool.Models;


namespace StudentManagmentHighSchool.Models
{
    public class MarkList
    {
        public int MarkListId { get; set; }

        public int AdmissionId { get; set; }
        public int CourseId { get; set; }
        public float Mark { get; set; }
        public string Semister { get; set; }

        public Admission Admission { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}