using MediatR;

namespace UpSchool_CQRS_Projects.CQRS.Commands.UniversityCommand
{
    public class RemoveUniversityCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveUniversityCommand(int id)
        {
            Id = id;
        }
    }
}
