using System.ComponentModel.DataAnnotations;
using static Contacts.Data.DataConstants.AppUser;

namespace Contacts.Models.User
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Username")]
        [StringLength(AppUserNameMaxLength, MinimumLength = AppUserNameMinLength)]
        public string UserName { get; set; } = null!;

        [Required]
        [EmailAddress]
        [StringLength(AppUserEmailMaxLength, MinimumLength = AppUserEmailMinLength)]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(AppUserPasswordMaxLength, MinimumLength = AppUserPasswordMinLength)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = null!;
    }
}
