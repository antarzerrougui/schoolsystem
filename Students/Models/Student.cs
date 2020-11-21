using System;
using System.ComponentModel.DataAnnotations;

namespace Students.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        
        public string ParentFirstName { get; set; }
        public string ParentLasttName { get; set; }
        public string ParentProfession { get; set; }
        public string MotherName { get; set; }
        public int ParentPhone { get; set; }
        public int BrothersNumber { get; set; }
        public int BrothersInSchool { get; set; }
        public bool IsOrphan { get; set; }


        public int Absence { get; set; }
        public string Observations { get; set; }
        public string FamilyStatus { get; set; }

    }
}
