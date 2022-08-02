using System.ComponentModel.DataAnnotations;

namespace Arabitey.ViewModel
{
    public class RegisterViewModel
    {
       
        [Required]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please Enter Vaild Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Repeat The Same Password")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required( ErrorMessage ="National_ID Length Must Be 14 Number")]
        [MaxLength(14)]
        [MinLength(14)]
        public string National_ID { get; set; }
        [Required(ErrorMessage = "Please Enter Your Address")]
        public string Address { get; set; }
    }
}
