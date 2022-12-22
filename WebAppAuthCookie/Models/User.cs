using System.ComponentModel.DataAnnotations;

namespace WebAppAuthCookie.Models
{
    public class User
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        [DataType(DataType.Password)]

        public string Password { get; set; }

    }
}
