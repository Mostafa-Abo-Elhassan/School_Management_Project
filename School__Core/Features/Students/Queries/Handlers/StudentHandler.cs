using MediatR;
using School__Core.Features.Students.Queries.Models;
using School_Data.Entities;
using School_Infrastracture.Data;
using School_Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School__Core.Features.Students.Queries.Handlers
{
    public class StudentHandler : IRequestHandler<GetStudentListQuery, List<Student>>
    {
        private readonly IStudentService _studentService;

        #region Fields



        #endregion


        #region constractors
        public StudentHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }

        #endregion



        #region Handle functionalty

        public async Task<List<Student>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
          return await  _studentService.GetStudentsAsync();
        }

        #endregion

    }
}
