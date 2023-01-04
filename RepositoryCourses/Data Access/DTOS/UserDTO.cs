using System.ComponentModel.DataAnnotations;

namespace RepositoryCourses.Data_Access.DTOS
{
    public class UserDTO
    {
        [Required]
        public string Name { get; set; }
    }
}
