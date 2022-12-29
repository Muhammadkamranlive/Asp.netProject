namespace RepositoryCourses.Models
{
    public class Category
    {
        public Category()
        {
            Courses = new HashSet<Course>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
