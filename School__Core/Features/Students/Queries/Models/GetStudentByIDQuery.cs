using MediatR;
using School__Core.Bases;
using School__Core.Features.Students.Queries.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School__Core.Features.Students.Queries.Models
{
    public class GetStudentByIDQuery:IRequest<Response<GetStudentByIDResponse>>
    {
        public int Id { get; set; }
        //public GetStudentByIDQuery(int id)
        //{
        //    int Id = id;
        //}

    }

}
