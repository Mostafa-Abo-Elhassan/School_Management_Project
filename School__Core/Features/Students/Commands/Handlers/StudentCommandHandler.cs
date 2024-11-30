using AutoMapper;
using MediatR;
using School__Core.Bases;
using School__Core.Features.Students.Commands.Models;
using School__Core.Features.Students.Queries.Models;
using School__Core.Features.Students.Queries.Response;
using School_Data.Entities;
using School_Service.Abstract;
using SchoolProject.Core.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School__Core.Features.Students.Commands.Handlers
{
    internal class StudentCommandHandler : ResponseHandler, IRequestHandler<AddStudentCommand, Response<string>>
    {
        #region Fields

        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;


        #endregion


        #region constractors
        public StudentCommandHandler(IStudentService studentService, IMapper mapper)
        {
            _mapper = mapper;
            _studentService = studentService;
        }

        #endregion

        public async Task<Response<string>> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and student
            var studentmapper = _mapper.Map<Student>(request);
            //add
            var result = await _studentService.AddAsync(studentmapper);
            // Condition
            if (result == "Exist")
            {
                return UnprocessableEntity<string>("name is an exist");
            }
            //return response
            else if (result == "Success")
            {
                return Created("Added Successfully");
            }
            else return BadRequest<string>();
        }
    }
}
