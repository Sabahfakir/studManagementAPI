using studManagementAPI.Models;
using studManagementAPI.Repository;

namespace studManagementAPI.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<Student> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task Add(Student student)
        {
            student.CreatedDate = DateTime.Now;
            await _repository.Add(student);
        }

        public async Task Update(Student student)
        {
            await _repository.Update(student);
        }

        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }
    }
}
