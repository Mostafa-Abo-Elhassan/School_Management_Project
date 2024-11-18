using School__Core.Features.Students.Queries.Response;
using School_Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School__Core.Mapping.StudentMap
{
    public partial class StudentProfile
    {
        public void GetStudentListMapping()
        {
            CreateMap<Student, GetStudentListResponse>()
                .ForMember(des => des.DepartmentName, o => o.MapFrom(src => src.Department.DName));
        }
    }
}
