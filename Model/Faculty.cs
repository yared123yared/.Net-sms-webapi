using System;
using System.ComponentModel.DataAnnotations;

namespace smsapi.Model
{
    public class Faculty
    {
        [Key]
        public int FacultyId { get; set; }
        public String FacultyName { get; set; }
    }
}