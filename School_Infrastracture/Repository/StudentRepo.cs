using Microsoft.EntityFrameworkCore;
using School_Data.Entities;
using School_Infrastracture.Abstract;
using School_Infrastracture.Data;
using School_Infrastracture.Infrastracture_Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Infrastracture.Repository
{
    public class StudentRepo : GenericRepositoryAsync<Student>, IStudentRepo
    {
        #region Fields

        private readonly DbSet<Student> _students;

        #endregion


        #region constractors

        public StudentRepo(ApplicationDBContext dBContext):base(dBContext)
        {
            _students = dBContext.Set<Student>();
        }

        #endregion



        #region Handles Methods

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _students.Include(x => x.Department).ToListAsync();
        }

        #endregion



    }
}
