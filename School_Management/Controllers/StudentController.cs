using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School__Core.Features.Students.Queries.Models;

namespace School_Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("/Student/List")]
        public async Task< IActionResult> GetStudentList()
        {
            var response = await _mediator.Send(new GetStudentListQuery());
            return Ok(response);
        }
        [HttpGet("/Student/{id}")]
        public async Task<IActionResult> GetStudenByID([FromRoute] int id )
        {
            var response = await _mediator.Send(new GetStudentByIDQuery() { Id=id});
            return Ok(response);
        }
    }
}
