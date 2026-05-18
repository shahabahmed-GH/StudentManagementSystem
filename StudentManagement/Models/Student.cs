using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models
{
    public class Student
    {
        public int ID {  get; set; }

        [Required,StringLength(20)] 
        public string Name { get; set; }

        [Required, StringLength(30)]

        public required string Email { get; set; }

        [Required, StringLength(15)]
        public required string Course { get; set; } 

        public  string? Batch { get; set; } 
    }
}
