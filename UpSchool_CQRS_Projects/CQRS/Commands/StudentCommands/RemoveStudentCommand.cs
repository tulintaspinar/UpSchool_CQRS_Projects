namespace UpSchool_CQRS_Projects.CQRS.Commands.StudentCommands
{
    public class RemoveStudentCommand
    {
        public int Id { get; set; }

        public RemoveStudentCommand(int ıd)
        {
            Id = ıd;
        }
    }
}
