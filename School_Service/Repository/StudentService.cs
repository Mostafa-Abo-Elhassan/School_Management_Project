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

      
        private readonly IStudentRepo studentRepo;

        #endregion


        #region constractors

        public StudentService(IStudentRepo  studentRepo)
        {
           
            this.studentRepo = studentRepo;
        }

        #endregion



        #region Handles Methods

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await studentRepo.GetStudentsAsync();
        }


        #endregion

    }
}
