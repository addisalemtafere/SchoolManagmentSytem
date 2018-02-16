using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagmentHighSchool.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Region { get; set; }
        public string Ciity { get; set; }
        public string kebele { get; set; }
        public string Email { get; set; }
        public int Telephone { get; set; }
        public virtual  Staff Staff { get; set; }
        public virtual Student Student { get; set; }
    }
}