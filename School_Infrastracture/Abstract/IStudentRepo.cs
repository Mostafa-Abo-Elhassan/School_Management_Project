using School_Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Infrastracture.Abstract
{
    public interface IStudentRepo
    {
        public Task<List<Student>> GetStudentsAsync();
    }
}
