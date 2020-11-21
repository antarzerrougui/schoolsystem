using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Students.Models
{
    public class Classe
    {
        [Key]
        public int ClasseId { get; set; }
        public int ClasseNumber { get; set; }
        public string ClasseLevel { get; set; }
        public IEnumerable<Student> ClasseStudents { get; set; }
    }
}
