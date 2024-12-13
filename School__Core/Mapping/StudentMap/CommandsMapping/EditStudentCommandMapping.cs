using School__Core.Features.Students.Commands.Models;
using School_Data.Entities;

namespace School__Core.Mapping.StudentMap
{
    public partial class StudentProfile
    {
        public void EditStudentCommandMapping()
        {
            CreateMap<EditStudentCommand, Student>()
                .ForMember(des => des.DID, o => o.MapFrom(src => src.DpartmentID))
            .ForMember(dest => dest.StudID, opt => opt.MapFrom(src => src.Id));
        }
    }

}
