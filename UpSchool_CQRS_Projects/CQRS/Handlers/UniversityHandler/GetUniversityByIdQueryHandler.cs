using MediatR;
using System.Threading;
using System.Threading.Tasks;
using UpSchool_CQRS_Projects.CQRS.Queries.UniversityQueries;
using UpSchool_CQRS_Projects.CQRS.Results.UniversityResults;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.UniversityHandler
{
    public class GetUniversityByIdQueryHandler : IRequestHandler<GetUniversityByIdQuery, GetUniversityByIdQueryResult>
    {
        private readonly ProductContext _context;

        public GetUniversityByIdQueryHandler(ProductContext context)
        {
            _context = context;
        }

        public async Task<GetUniversityByIdQueryResult> Handle(GetUniversityByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Universities.FindAsync(request.Id);
            return new GetUniversityByIdQueryResult
            {
                UniversityID = values.UniversityID,
                Name= values.Name,
                City= values.City,
                Population = values.Population
            };
        }
    }
}
