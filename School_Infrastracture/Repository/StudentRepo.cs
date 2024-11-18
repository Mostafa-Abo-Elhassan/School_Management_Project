using Microsoft.EntityFrameworkCore;
using School_Data.Entities;
using School_Infrastracture.Abstract;
using School_Infrastracture.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Infrastracture.Repository
{
    public class StudentRepo : IStudentRepo
    {
        #region Fields

        private readonly ApplicationDBContext _dBContext;

        #endregion


        #region constractors

        public StudentRepo(ApplicationDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        #endregion



        #region Handles Methods

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _dBContext.Students.Include(src=>src.Department).ToListAsync();
        }

        #endregion



    }
}
