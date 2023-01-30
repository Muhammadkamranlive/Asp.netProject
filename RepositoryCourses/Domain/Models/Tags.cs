namespace RepositoryCourses.Models
{
    public class Tag
    {
        public Tag()
        {
            Courses = new HashSet<Course>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }

}
