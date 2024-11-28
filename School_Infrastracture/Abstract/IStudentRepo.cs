using School_Data.Entities;
using School_Infrastracture.Infrastracture_Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Infrastracture.Abstract
{
    public interface IStudentRepo : IGenericRepositoryAsync<Student>
    {
        public Task<List<Student>> GetStudentsAsync();
    }
}
