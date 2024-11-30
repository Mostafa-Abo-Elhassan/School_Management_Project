using AutoMapper;
using Azure.Core;
using MediatR;
using School__Core.Bases;
using School__Core.Features.Students.Queries.Models;
using School__Core.Features.Students.Queries.Response;
using School_Data.Entities;
using School_Infrastracture.Data;
using School_Service.Abstract;
using SchoolProject.Core.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School__Core.Features.Students.Queries.Handlers
{
    public class StudentHandler : ResponseHandler, IRequestHandler<GetStudentListQuery, Response<List<GetStudentListResponse>>>
                                                 , IRequestHandler<GetStudentByIDQuery, Response<GetStudentByIDResponse>>
    {

        #region Fields

        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;


        #endregion


        #region constractors
        public StudentHandler(IStudentService studentService , IMapper mapper)
        {
              _mapper = mapper;
              _studentService = studentService;
        }

        #endregion



        #region Handle functionalty

        public async Task<Response<List<GetStudentListResponse>>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {

          var studentlist  =  await  _studentService.GetStudentsAsync();
          var studentlistmapper = _mapper.Map<List<GetStudentListResponse>>(studentlist);
          return Success  (studentlistmapper);

        }

        public async Task<Response<GetStudentByIDResponse>> Handle(GetStudentByIDQuery request, CancellationToken cancellationToken)
        {
            var student = await _studentService.GetByIDAsync(request.Id);
            if (student == null)
            {
                return NotFound<GetStudentByIDResponse>("No Found");
            }
            var result = _mapper.Map<GetStudentByIDResponse>(student);
            return Success(result);
        }
 //       var student = await _studentService.GetStudentByIDWithIncludeAsync(request.Id);
 //if (student==null) return NotFound<GetSingleStudentResponse>(_stringLocalizer[SharedResourcesKeys.NotFound]);
 //var result = _mapper.Map<GetSingleStudentResponse>(student);
 //return Success(result);

        #endregion

    }
}
