using System;
using System.ComponentModel.DataAnnotations;

namespace smsapi.Model
{
    public class Grade
    {
        [Key]

        public int CoNo { get; set; }
        public int StudentId { get; set; }
        public int SemesterId { get; set; }
        public int Mark { get; set; }
    }
}