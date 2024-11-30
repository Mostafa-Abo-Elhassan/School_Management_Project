using Microsoft.EntityFrameworkCore;
using School_Data.Entities;
using School_Infrastracture.Abstract;
using School_Infrastracture.Data;
using School_Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Service.Repository
{
    public class StudentService : IStudentService
    {
      

        #region Fields

      
        private readonly IStudentRepo _studentRepo;

        #endregion


        #region constractors

        public StudentService(IStudentRepo  studentRepo)
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
        //    var studentExist = await _studentRepo.GetTableNoTracking().Where(x => x.Name.Equals(student.Name)).FirstOrDefaultAsync();
        //    if (studentExist!=null)  return "this student is an exist ";
            
           
            await _studentRepo.AddAsync(student);
            return "Success";
        }


        #endregion

    }
}
