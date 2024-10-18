using System.ComponentModel.DataAnnotations;

namespace library.Models
{
    public class Student
    {
        [Key]
        public int stuId { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Firstname mast greater than 3 length")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Lastname mast greater than 3 length")]
        public string LastName { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
