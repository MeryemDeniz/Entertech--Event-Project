using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Xunit.Abstractions;

namespace Event_Project.Models.View
{
    public class RegisterView
    {
        [Required(ErrorMessage = "Name should not be left blank...")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "SurName should not be left blank...")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email should not be left blank...")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Password should not be left blank...")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters...")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Password should not be left blank...")]
        [DataType(DataType.Password)]
        [Display(Name = "New Password  (Re-enter)")]
        [Compare("Password", ErrorMessage = "Passwords could not be matched...")]
        public string ConfirmPassword { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "User Terms must be accepted...")]
        public bool CheckUserTermsButton { get; set; }
    }
}
