using System;
using System.ComponentModel.DataAnnotations;

namespace smsapi.Model
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public String FName { get; set; }
        public String LName { get; set; }
        public DateTime DOB { get; set; }
        public int DepartmentId { get; set; }
        public String Gender { get; set; }
        public string Email { get; set; }
    }
}
