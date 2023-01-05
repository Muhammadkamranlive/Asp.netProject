namespace RepositoryCourses.Data_Access.DTOS
{
    public class CourseDTO
    {
        public CourseDTO()
        {
            Teacher = new HashSet<TeachersDTO>();
            Tags = new HashSet<TagDTO>();
            Students = new HashSet<StudentDTO>();
        }
        public int Id { get; set; }
        public string CourseTitle { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public float? FullPrice { get; set; }
        public virtual CategoryDTO? Category { get; set; }
        public virtual CoverDTO? Cover { get; set; }
        public virtual ICollection<TeachersDTO>? Teacher { get; set; }
        public virtual ICollection<TagDTO>? Tags { get; set; }
        public virtual ICollection<StudentDTO>? Students { get; set; }
    }
}
