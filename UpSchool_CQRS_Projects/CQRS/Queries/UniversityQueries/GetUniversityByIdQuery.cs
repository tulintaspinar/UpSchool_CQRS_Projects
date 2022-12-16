using MediatR;
using UpSchool_CQRS_Projects.CQRS.Results.UniversityResults;

namespace UpSchool_CQRS_Projects.CQRS.Queries.UniversityQueries
{
    public class GetUniversityByIdQuery : IRequest<GetUniversityByIdQueryResult>
    {
        public int Id { get; set; }

        public GetUniversityByIdQuery(int id)
        {
            Id = id;
        }
    }
}
