using RepositoryCourses.Data_Access.DTOS;

namespace RepositoryCourses.CourseServices
{
    public interface ITeacherSertvice
    {
        Task<IEnumerable<TeachersDTO>> GetAllTeachers();
        Task<TeachersDTO> GetById(int id);
        Task Delete(int id);
        void Update(TeachersDTO teachersDTO);
        Task InsertAsync(TeachersDTO teachersDTO);
        Task<int> CompletedAsync();




    }
}
