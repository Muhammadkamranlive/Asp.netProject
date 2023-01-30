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
        public string CourseTitle { get; set; }

        public string Description { get; set; }

        public int Level { get; set; }

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
