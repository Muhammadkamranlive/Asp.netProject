using System.ComponentModel.DataAnnotations.Schema;

namespace RepositoryCourses.Models
{
    [Table("Teachers")]
    public class Teachers : User
    {
        public Teachers()
        {
            Courses = new HashSet<Course>();
            Students = new HashSet<Student>();
        }


        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }

}
