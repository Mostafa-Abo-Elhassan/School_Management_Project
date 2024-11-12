using School_Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Service.Abstract
{
    public interface IStudentService
    {
        public Task<List<Student>> GetStudentsAsync();


    }
}
