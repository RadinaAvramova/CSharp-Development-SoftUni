using System.ComponentModel.DataAnnotations;
using static Contacts.Data.DataConstants.AppUser;

namespace Contacts.Models.User
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Username")]
        [StringLength(AppUserNameMaxLength, MinimumLength = AppUserNameMinLength)]
        public string UserName { get; set; } = null!;

        [Required]
        [StringLength(AppUserPasswordMaxLength, MinimumLength = AppUserPasswordMinLength)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
    }
}
