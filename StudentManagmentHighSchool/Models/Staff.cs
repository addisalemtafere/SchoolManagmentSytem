using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentManagmentHighSchool.Models
{
    public class Staff
    {
        public Staff(){}
        
       
        public int StaffId { get; set; }
        public string Firstname { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public string Gender { get; set; }
        public DateTime EmploymentDate { get; set; }
        public  string Qualification { get; set; }
        public  Address Address { get; set; }



    }
}