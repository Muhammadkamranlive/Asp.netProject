using System.ComponentModel.DataAnnotations;

namespace RepositoryCourses.Models
{
    public class Tag
    {
        public Tag()
        {
            Courses = new HashSet<Course>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Tag Name is Required")]
        [MinLength(1)]
        [MaxLength(20)]
        public string Title { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }

}
