using System.ComponentModel.DataAnnotations;

namespace RepositoryCourses.Models
{
    public class Course
    {
        public Course()
        {
            Tags = new HashSet<Tag>();
            Students = new HashSet<Student>();
            Teacher = new HashSet<Teachers>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Course Title is Required")]
        [MinLength(5)]
        [MaxLength(50)]
        public string CourseTitle { get; set; }

        [Required(ErrorMessage = "Course Description is Required")]
        [MinLength(5)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please add course level")]
        public int Level { get; set; }

        [Required(ErrorMessage = "Please add course price")]
        [Range(100, int.MaxValue, ErrorMessage = "Please enter a price bigger than {100}")]
        public float FullPrice { get; set; }

        public virtual Category? Category { get; set; }
        public virtual Cover? Cover { get; set; }
        public virtual ICollection<Teachers>? Teacher { get; set; }
        public virtual ICollection<Tag>? Tags { get; set; }
        public virtual ICollection<Student>? Students { get; set; }
        public bool IsBeginnerCourse
        {
            get { return Level == 1; }
        }
    }

}
