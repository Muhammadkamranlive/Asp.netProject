using System.ComponentModel.DataAnnotations;

namespace RepositoryCourses.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [MinLength(1)]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
