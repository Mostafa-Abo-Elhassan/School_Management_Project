using School__Core.Features.Students.Queries.Response;
using School_Data.Entities;

namespace School__Core.Mapping.StudentMap
{
    public partial class StudentProfile
    {
        public void GetStudentPaginationMapping()
        {
            CreateMap<Student, GetStudentPaginatedListResponse>()
               .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department))
               .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
               .ForMember(dest => dest.StudID, opt => opt.MapFrom(src => src.StudID))
               .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address));
        }
    }
}
