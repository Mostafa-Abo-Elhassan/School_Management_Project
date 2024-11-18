using AutoMapper;
using MediatR;
using School__Core.Features.Students.Queries.Models;
using School__Core.Features.Students.Queries.Response;
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
    public class StudentHandler : IRequestHandler<GetStudentListQuery, List<GetStudentListResponse>>
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        #region Fields



        #endregion


        #region constractors
        public StudentHandler(IStudentService studentService , IMapper mapper)
        {
              _mapper = mapper;
              _studentService = studentService;
        }

        #endregion



        #region Handle functionalty

        public async Task<List<GetStudentListResponse>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {

          var studentlist  =  await  _studentService.GetStudentsAsync();
          var studentlistmapper = _mapper.Map<List<GetStudentListResponse>>(studentlist);
          return studentlistmapper;

        }

        #endregion

    }
}
