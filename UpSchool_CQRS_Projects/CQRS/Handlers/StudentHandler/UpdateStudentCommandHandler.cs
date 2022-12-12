using UpSchool_CQRS_Projects.CQRS.Commands.StudentCommands;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.StudentHandler
{
    public class UpdateStudentCommandHandler
    {
        private readonly ProductContext _context;

        public UpdateStudentCommandHandler(ProductContext context)
        {
            _context = context;
        }
        public void Handle(UpdateStudentCommand command)
        {
            var value = _context.Students.Find(command.StudentID);
            value.City= command.City;
            value.Age= command.Age;
            value.Name= command.Name;
            value.Surname= command.Surname;
            _context.SaveChanges();
        }
    }
}
