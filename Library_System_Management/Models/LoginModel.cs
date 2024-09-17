using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Library_System_Management.Models
{
    public class LoginModel
    {
        [Key]
        [Required(ErrorMessage = "User Name or Email is Required")]
        public string UserNameOrEmail { get; set; }
        [DisplayName("Username or Email")]

        [Required(ErrorMessage = "First Name is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
