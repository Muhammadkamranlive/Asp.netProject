using System.ComponentModel.DataAnnotations;

namespace RepositoryCourses.Models
{
    public class Category
    {
        public Category()
        {
            Courses = new HashSet<Course>();
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "Category Name is Required")]
        [MinLength(1)]
        [MaxLength(20)]
        public string Name { get; set; }
        public virtual ICollection<Course>? Courses { get; set; }
    }
}
