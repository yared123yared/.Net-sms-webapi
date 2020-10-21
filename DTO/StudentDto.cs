using System;


namespace smsapi.DTO
{
    public class StudentDto
    {
        [Required]
        public int StudentId { get; set; }
        [Required]
        public String FName { get; set; }
        [Required]
        public String LName { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public int DepartmentId { get; set; }
        [Required]
        public String Gender { get; set; }
        [Required]
        public string Email { get; set; }
      
    }
}
