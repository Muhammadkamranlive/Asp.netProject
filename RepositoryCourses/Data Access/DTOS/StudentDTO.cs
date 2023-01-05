namespace RepositoryCourses.Data_Access.DTOS
{
    public class StudentDTO : UserDTO
    {
        public StudentDTO()
        {
            Teacher = new HashSet<TeachersDTO>();
            Courses = new HashSet<CourseDTO>();
        }
        public virtual ICollection<TeachersDTO>? Teacher { get; set; }
        public virtual ICollection<CourseDTO>? Courses { get; set; }
    }
}
