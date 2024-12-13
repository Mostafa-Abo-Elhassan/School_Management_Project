using MediatR;
using School__Core.Features.Students.Queries.Response;
using School__Core.Wrappers;

namespace School__Core.Features.Students.Queries.Models
{
    public class GetStudentPaginatedListQuery : IRequest<PaginatedResult<GetStudentPaginatedListResponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string[]? OrderBy { get; set; }
        public string? Search { get; set; }
    }
}
