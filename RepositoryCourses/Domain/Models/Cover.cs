namespace RepositoryCourses.Models
{
    public class Cover
    {
        public int Id { get; set; }
        public string? CoverTitle { get; set; }
        public virtual ICollection<Course>? Courses { get; set; }
    }
}
