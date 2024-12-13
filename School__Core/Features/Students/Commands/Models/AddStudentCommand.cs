using MediatR;
using School__Core.Bases;

namespace School__Core.Features.Students.Commands.Models
{
    public class AddStudentCommand : IRequest<Response<string>>
    {


        public string Name { get; set; }


        public string Address { get; set; }


        public string Phone { get; set; }

        public int DpartmentID { get; set; }

    }
}
