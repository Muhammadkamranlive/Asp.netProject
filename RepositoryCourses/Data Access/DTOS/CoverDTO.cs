namespace RepositoryCourses.Data_Access.DTOS
{
    public class CoverDTO
    {
        public CoverDTO()
        {
            Courses = new HashSet<CourseDTO>();
        }
        public int Id { get; set; }
        public string? CoverTitle { get; set; }
        public virtual ICollection<CourseDTO>? Courses { get; set; }
    }
}
