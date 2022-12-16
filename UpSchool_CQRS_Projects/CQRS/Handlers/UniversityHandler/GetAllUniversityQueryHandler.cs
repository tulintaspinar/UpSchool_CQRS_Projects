using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UpSchool_CQRS_Projects.CQRS.Queries.UniversityQueries;
using UpSchool_CQRS_Projects.CQRS.Results.UniversityResults;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.UniversityHandler
{
    public class GetAllUniversityQueryHandler : IRequestHandler<GetAllUniversityQuery,List<GetAllUniversityQueryResult>>
    {
        private readonly ProductContext _context;

        public GetAllUniversityQueryHandler(ProductContext context)
        {
            _context = context;
        }

        public async Task<List<GetAllUniversityQueryResult>> Handle(GetAllUniversityQuery request, CancellationToken cancellationToken)
        {
            return await _context.Universities.Select(x => new GetAllUniversityQueryResult
            {
                UniversityID=x.UniversityID,
                Town=x.City,
                Name=x.Name
            }).AsNoTracking().ToListAsync();
        }
    }
}
