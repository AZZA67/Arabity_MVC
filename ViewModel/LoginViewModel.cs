using System.ComponentModel.DataAnnotations;

namespace Arabitey.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        public string USerName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool isPersistent { get; set; }

    }
}
