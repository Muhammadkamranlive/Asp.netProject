namespace RepositoryCourses.Data_Access.DTOS
{
    public class TagDTO
    {
        public TagDTO()
        {
            Courses = new HashSet<CourseDTO>();
        }


        public string Title { get; set; }

        public virtual ICollection<CourseDTO>? Courses { get; set; }
    }
}
