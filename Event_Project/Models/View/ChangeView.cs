using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Xunit.Abstractions;

namespace Event_Project.Models.View
{
    public class ChangeView
    {
        [Required(ErrorMessage = "Old password field should not be left blank...")]
        [DataType(DataType.Password)]
        [Display(Name = "Old Password")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "New password field should not be left blank...")]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters...")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "New password field should not be left blank...")]
        [DataType(DataType.Password)]
        [Display(Name = "New Password  (Re-enter)")]
        [Compare("NewPassword", ErrorMessage = "Passwords could not be matched...")]
        public string ConfirmPassword { get; set; }
    }
}
