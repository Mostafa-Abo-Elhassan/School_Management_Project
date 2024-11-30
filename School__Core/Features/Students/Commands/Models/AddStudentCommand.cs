using MediatR;
using School__Core.Bases;
using School__Core.Features.Students.Queries.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
