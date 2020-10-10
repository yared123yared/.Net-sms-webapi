using System;
using System.ComponentModel.DataAnnotations;

namespace smsapi.Model
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public String DepartmentName { get; set; }
        public String FacultyId { get; set; }
    }
}