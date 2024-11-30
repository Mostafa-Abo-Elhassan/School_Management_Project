using School__Core.Features.Students.Commands.Models;
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
        public void AddStudentCommandMapping()
        {
            CreateMap<AddStudentCommand, Student>()
                .ForMember(des => des.DID, o => o.MapFrom(src => src.DpartmentID));
        }


    }
}