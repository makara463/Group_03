using System.ComponentModel.DataAnnotations;

namespace Library_System_Management.Entities
{
    public class RegisterUser
    {
        [Key]
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



        [Compare("Password", ErrorMessage = "Please Confirm Your Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
