using MediatR;
using System.Threading;
using System.Threading.Tasks;
using UpSchool_CQRS_Projects.CQRS.Commands.UniversityCommand;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.UniversityHandler
{
    public class RemoveUniversityCommandHandler : IRequestHandler<RemoveUniversityCommand>
    {
        private readonly ProductContext _context;

        public RemoveUniversityCommandHandler(ProductContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(RemoveUniversityCommand request, CancellationToken cancellationToken)
        {
            var value = _context.Universities.Find(request.Id);
            _context.Universities.Remove(value);
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
