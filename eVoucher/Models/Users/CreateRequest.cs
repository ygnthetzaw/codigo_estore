using System.ComponentModel.DataAnnotations;
using eVoucher.Entities;

namespace eVoucher.Models.Users
{
    public class CreateRequest
    {

        [Required]
        public string FullName { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}