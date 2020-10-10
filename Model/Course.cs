using System;
using System.ComponentModel.DataAnnotations;

namespace smsapi.Model
{
    public class Course
    {
        [Key]
        public int CoNo { get; set; }
        public String CoTitle { get; set; }
        public int CrHr { get; set; }
    }
}