namespace RepositoryCourses.Data_Access.DTOS
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<CourseDTO> Courses { get; set; }
    }
}
