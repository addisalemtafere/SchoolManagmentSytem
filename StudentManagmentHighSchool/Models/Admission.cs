using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagmentHighSchool.Models
{
    public class Admission
    {

        public int AdmissionId { get; set; }
        public int StudentId { get; set; }
        public DateTime AdmitionYear { get; set; }
        public int Grade { get; set; }
        public Student Student { get; set; }
        public virtual ICollection<MarkList> MarkLists { get; set; }    
    }
}