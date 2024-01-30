using System.ComponentModel.DataAnnotations;

namespace AspNetCoreDemo.Models
{
    public class UserProfile
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Email { get; set; }

        public string? ProfilePicture { get; set; }

        public string? Bio { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
