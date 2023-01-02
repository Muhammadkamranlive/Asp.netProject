using System.ComponentModel.DataAnnotations;

namespace RepositoryCourses.Data_Access.DTOS.Authentications
{
    public class UserLoginDTO
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
