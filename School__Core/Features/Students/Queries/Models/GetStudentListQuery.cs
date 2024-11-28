using MediatR;
using School__Core.Bases;
using School__Core.Features.Students.Queries.Response;
using School_Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School__Core.Features.Students.Queries.Models
{
    public class GetStudentListQuery:IRequest<Response<List<GetStudentListResponse>>>
    {
    }
}
