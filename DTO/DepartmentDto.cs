using System;
using System.ComponentModel.DataAnnotations;

namespace smsapi.DTO
{
    public class DepartmentDto
    {
        [Required]
        public int DepartmentId { get; set; }
        [Required]
        public String DepartmentName { get; set; }


    }
}