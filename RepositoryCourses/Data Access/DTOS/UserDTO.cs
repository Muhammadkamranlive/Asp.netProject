using System.ComponentModel.DataAnnotations;

namespace RepositoryCourses.Data_Access.DTOS
{
    public class UserDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [MinLength(1)]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
