using MediatR;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School__Core.Features.Students.Commands.Models;
using School__Core.Features.Students.Queries.Models;
using School_Data.Routing;
using School_Management.Base;

namespace School_Management.Controllers
{
   
    [ApiController]
    public class StudentController : AppControllerBase
    {
        
        [HttpGet(Routing.StudentRoute.List)]
        public async Task< IActionResult> GetStudentList()
        {
            var response = await Mediator.Send(new GetStudentListQuery());
            return Ok(response);
        }
        [HttpGet(Routing.StudentRoute.GetByID)]
        public async Task<IActionResult> GetStudenByID( int id )
        {
            return NewResult(await Mediator.Send(new GetStudentByIDQuery() { Id = id }));
        }
        [HttpPost(Routing.StudentRoute.Create)]
        public async Task<IActionResult> CreateStudent( AddStudentCommand addStudent)
        {
            return NewResult(await Mediator.Send(addStudent));
        }
    }
}
