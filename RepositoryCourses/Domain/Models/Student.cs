using System.ComponentModel.DataAnnotations.Schema;

namespace RepositoryCourses.Models
{
    [Table("Students")]
    public class Student : User
    {
        public Student()
        {
            Teacher = new HashSet<Teachers>();
            Courses = new HashSet<Course>();
        }

        public virtual ICollection<Teachers> Teacher { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
