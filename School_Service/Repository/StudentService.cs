using Microsoft.EntityFrameworkCore;
using School_Data.Entities;
using School_Infrastracture.Abstract;
using School_Service.Abstract;

namespace School_Service.Repository
{
    public class StudentService : IStudentService
    {


        #region Fields


        private readonly IStudentRepo _studentRepo;

        #endregion


        #region constractors

        public StudentService(IStudentRepo studentRepo)
        {

            _studentRepo = studentRepo;
        }


        #endregion



        #region Handles Methods

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _studentRepo.GetStudentsAsync();
        }
        public async Task<Student> GetByIDAsync(int id)
        {
            var student = await _studentRepo.GetTableNoTracking().Include(x => x.Department).Where(x => x.StudID.Equals(id)).FirstOrDefaultAsync();
            //
            //GetTableNoTracking()
            //                              .Include(x => x.Department)
            //                              .Where(x => x.StudID.Equals(id))
            //                              .FirstOrDefault();
            return student;
        }

        public async Task<string> AddAsync(Student student)
        {
            var studentExist = await _studentRepo.GetTableNoTracking().Where(x => x.Name.Equals(student.Name)).FirstOrDefaultAsync();
            if (studentExist != null)
            {
                await _studentRepo.AddAsync(student);
                return "Success";

            }
            else
            {
                return "Exist";
            }

        }

        public async Task<string> EditAsync(Student student)
        {
            await _studentRepo.UpdateAsync(student);
            return "Success";
        }

        public async Task<string> removeAsync(Student student)
        {
            var studentExist = await _studentRepo.GetTableNoTracking().Where(x => x.StudID.Equals(student.StudID)).FirstOrDefaultAsync();
            if (studentExist != null)

                await _studentRepo.DeleteAsync(student);
            return "Success";




        }

        public IQueryable<Student> GetStudentsQuerable()
        {
            return _studentRepo.GetTableNoTracking().Include(x => x.Department).AsQueryable();
        }

        public IQueryable<Student> FilterStudentPaginatedQuerable(string search)
        {
            var querable = _studentRepo.GetTableNoTracking().Include(x => x.Department).AsQueryable();
            if (search != null)
            {
                querable = querable.Where(x => x.Name.Contains(search) || x.Address.Contains(search));
            }
            return querable;
        }

        //public async Task<string> removeAsync(int id)
        //{
        //    await _studentRepo.DeleteAsync(id);
        //    return "Success";
        //}




        #endregion

    }
}
