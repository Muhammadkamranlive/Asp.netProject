using System.ComponentModel.DataAnnotations;

namespace RepositoryCourses.Models
{
    public class Cover
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Course Cover title is Required")]
        [MinLength(1)]
        [MaxLength(20)]
        public string? CoverTitle { get; set; }
        public virtual ICollection<Course>? Courses { get; set; }
    }
}
