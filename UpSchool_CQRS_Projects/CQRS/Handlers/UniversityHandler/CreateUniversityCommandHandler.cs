using MediatR;
using System.Threading;
using System.Threading.Tasks;
using UpSchool_CQRS_Projects.CQRS.Commands.UniversityCommand;
using UpSchool_CQRS_Projects.DAL.Context;
using UpSchool_CQRS_Projects.DAL.Entities;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.UniversityHandler
{
    public class CreateUniversityCommandHandler:IRequestHandler<CreateUniversityCommand>
    {
        private readonly ProductContext _context;

        public CreateUniversityCommandHandler(ProductContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateUniversityCommand request, CancellationToken cancellationToken)
        {
            _context.Add(new University
            {
                City= request.City,
                FacultyCount= request.FacultyCount,
                Name=request.Name,
                Population= request.Population
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
