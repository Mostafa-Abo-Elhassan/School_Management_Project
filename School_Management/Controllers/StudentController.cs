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
        public async Task<IActionResult> GetStudentList()
        {
            var response = await Mediator.Send(new GetStudentListQuery());
            return Ok(response);
        }

        [HttpGet(Routing.StudentRoute.paginatedlist)]
        public async Task<IActionResult> GetStudentPaginatedList([FromQuery] GetStudentPaginatedListQuery getStudentPaginated)
        {
            var response = await Mediator.Send(getStudentPaginated);
            return Ok(response);
        }

        [HttpGet(Routing.StudentRoute.GetByID)]
        public async Task<IActionResult> GetStudenByID(int id)
        {
            return NewResult(await Mediator.Send(new GetStudentByIDQuery() { Id = id }));
        }

        [HttpPost(Routing.StudentRoute.Create)]
        public async Task<IActionResult> CreateStudent(AddStudentCommand addStudent)
        {
            return NewResult(await Mediator.Send(addStudent));
        }

        [HttpPut(Routing.StudentRoute.Update)]
        public async Task<IActionResult> EditStudent(EditStudentCommand EditStudent)
        {
            return NewResult(await Mediator.Send(EditStudent));
        }

        [HttpDelete(Routing.StudentRoute.Delete)]
        public async Task<IActionResult> RemoveStudent(int id)
        {
            return NewResult(await Mediator.Send(new DeleteStudentCommand(id)));
        }

    }
}
