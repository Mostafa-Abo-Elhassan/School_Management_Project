using AutoMapper;

namespace School__Core.Mapping.StudentMap
{
    public partial class StudentProfile : Profile
    {
        public StudentProfile()
        {
            GetStudentListMapping();
            GetStudentByIdMapping();
            AddStudentCommandMapping();
            EditStudentCommandMapping();
            GetStudentPaginationMapping();
        }

    }
}
