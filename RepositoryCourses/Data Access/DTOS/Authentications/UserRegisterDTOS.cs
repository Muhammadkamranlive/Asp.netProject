using System.ComponentModel.DataAnnotations;

namespace RepositoryCourses.Data_Access.DTOS.Authentications
{
    public class UserRegisterDTOS
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
