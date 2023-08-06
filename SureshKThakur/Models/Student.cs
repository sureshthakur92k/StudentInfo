using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SureshKThakur.Models
{
    public class Student
    {
        public Guid StudentGuid { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string StudentClass { get; set; }
        public string AdmissionDate { get; set; }
        public string StudentEmailId { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public string ParentsPhoneNo { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public string PolicStation { get; set; }
        public string PostOffice { get; set; }
        public int ClassId { get; set; }
        public int StateId { get; set; }
        public int DistrictId { get; set; }
        public string IsEdit { get; set; }
    }
}