using UpSchool_CQRS_Projects.CQRS.Commands.StudentCommands;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.StudentHandler
{
    public class RemoveStudentCommandHandler
    {
        private readonly ProductContext _context;

        public RemoveStudentCommandHandler(ProductContext context)
        {
            _context = context;
        }
        public void Handle(RemoveStudentCommand command)
        {
            var values = _context.Students.Find(command.Id);
            _context.Remove(values);
            _context.SaveChanges();
        }
    }
}
