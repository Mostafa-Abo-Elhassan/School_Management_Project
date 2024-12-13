using AutoMapper;
using MediatR;
using School__Core.Bases;
using School__Core.Features.Students.Commands.Models;
using School_Data.Entities;
using School_Service.Abstract;
using SchoolProject.Core.Bases;

namespace School__Core.Features.Students.Commands.Handlers
{
    internal class StudentCommandHandler : ResponseHandler, IRequestHandler<AddStudentCommand, Response<string>>
                                                          , IRequestHandler<EditStudentCommand, Response<string>>
                                                             , IRequestHandler<DeleteStudentCommand, Response<string>>
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

        public async Task<Response<string>> Handle(EditStudentCommand request, CancellationToken cancellationToken)
        {
            // Check if the Id is Exist Or not
            var student = await _studentService.GetByIDAsync(request.Id);
            //return NotFound
            if (student == null) return NotFound<string>();
            //mapping Between request and student
            var studentmapper = _mapper.Map<Student>(request);
            //add
            var result = await _studentService.EditAsync(studentmapper);
            if (result == "Success")
            {
                return Success("Updated Successfully");
            }
            else return BadRequest<string>();


        }

        public async Task<Response<string>> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            // Check if the Id is Exist Or not
            var student = await _studentService.GetByIDAsync(request.Id);
            //return NotFound
            if (student == null) return NotFound<string>();
            var result = await _studentService.removeAsync(student);
            if (result == "Success")
            {
                return Deleted<string>("Deleted Successfully");
            }
            else return BadRequest<string>();
        }


    }
}
