using System.ComponentModel.DataAnnotations;

namespace SecureApiWithJwtAuth.Models
{
    public class RegisterModel
    {
        [Required,StringLength(100)]
        public string FirstName {  get; set; }

        [Required, StringLength(100)]
        public string LastName { get; set; }

        [Required, StringLength(100)]
        public string Username { get; set; }

        [Required, StringLength(100)]
        public string Email { get; set; }

        [Required, StringLength(100)]
        public string Password { get; set; }
    }
}
