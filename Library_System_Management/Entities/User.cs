
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Library_System_Management.Entities
{
    [Index(nameof(Email), IsUnique = true)]
    [Index(nameof(UserName), IsUnique = true)]
    public class User
    {


        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "User Name is Required")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "First Name is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
