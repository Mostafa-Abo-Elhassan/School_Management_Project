using School_Data.Entities;

namespace School_Service.Abstract
{
    public interface IStudentService
    {
        public Task<List<Student>> GetStudentsAsync();
        public Task<Student> GetByIDAsync(int id);

        public Task<string> AddAsync(Student student);
        public Task<string> EditAsync(Student student);
        public Task<string> removeAsync(Student student);
        public IQueryable<Student> GetStudentsQuerable();
        public IQueryable<Student> FilterStudentPaginatedQuerable(string search);
    }
}
