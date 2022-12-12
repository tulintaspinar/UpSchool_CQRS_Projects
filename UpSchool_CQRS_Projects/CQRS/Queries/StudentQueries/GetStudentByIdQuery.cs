namespace UpSchool_CQRS_Projects.CQRS.Queries.StudentQueries
{
    public class GetStudentByIdQuery
    {
        public int Id { get; set; }

        public GetStudentByIdQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
