using MediatR;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School__Core.Features.Students.Queries.Models;
using School_Data.Routing;

namespace School_Management.Controllers
{
   
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet(Routing.StudentRoute.List)]
        public async Task< IActionResult> GetStudentList()
        {
            var response = await _mediator.Send(new GetStudentListQuery());
            return Ok(response);
        }
        [HttpGet(Routing.StudentRoute.GetByID)]
        public async Task<IActionResult> GetStudenByID( int id )
        {
            var response = await _mediator.Send(new GetStudentByIDQuery() { Id=id});
            return Ok(response);
        }
    }
}
