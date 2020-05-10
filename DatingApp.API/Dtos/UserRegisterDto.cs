using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserRegisterDto
    {
        [Required]
        [MinLength(3, ErrorMessage = "Username must be at least 3 characters!")]
        public string Username { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "Your password must be between 4 and 15 characters!" )]
        public string Password { get; set; }
    }
}