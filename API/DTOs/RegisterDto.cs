using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        public required string Username { get; set; }
        [Required]
        public required string Password { get; set; }
        [Required]
        public required string KnownAs { get; set; }
        [Required]
        public required string Gender { get; set; }
        [Required]
        public required string City { get; set; }
        [Required]
        public required string Country { get; set; }
    }
}