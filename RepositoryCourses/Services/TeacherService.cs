using AutoMapper;
using RepositoryCourses.Data_Access.DTOS;
using RepositoryCourses.Domain.Repositories;
using RepositoryCourses.Models;

namespace RepositoryCourses.CourseServices
{
    public class TeacherService : ITeacherSertvice
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public TeacherService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TeachersDTO>> GetAllTeachers()
        {
            var teachers = await _unitOfWork.Teacher.GetAll();
            return _mapper.Map<List<TeachersDTO>>(teachers);
        }

        public async Task<TeachersDTO> GetById(int id)
        {
            var teacher = await _unitOfWork.Teacher.Get(id);
            return _mapper.Map<TeachersDTO>(teacher);
        }

        public async Task InsertAsync(TeachersDTO teachersDTO)
        {
            var project = _mapper.Map<Teachers>(teachersDTO);
            var teacher = new Teachers() { Name = project.Name, Students = project.Students, Courses = project.Courses };
            await _unitOfWork.User.Add(project);
        }
        public async Task<int> CompletedAsync()
        {
            return await _unitOfWork.Save();
        }

        public async Task<bool> Delete(int id)
        {
           return await _unitOfWork.Teacher.Remove(id);
        }

        public void Update(TeachersDTO teachersDTO)
        {
            var teacher = _mapper.Map<Teachers>(teachersDTO);
            _unitOfWork.Teacher.Update(teacher);

        }
    }
}
