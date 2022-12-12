using UpSchool_CQRS_Projects.CQRS.Queries.StudentQueries;
using UpSchool_CQRS_Projects.CQRS.Results.StudentResults;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.StudentHandler
{
    public class GetStudentByIdQueryHandler
    {
        private readonly ProductContext _context;

        public GetStudentByIdQueryHandler(ProductContext context)
        {
            _context = context;
        }
        public GetStudentByIDQueryResult Handle(GetStudentByIdQuery query)
        {
            var value = _context.Students.Find(query.Id);
            return new GetStudentByIDQueryResult
            {
                Age=value.Age,
                City=value.City,
                Name=value.Name,
                Surname=value.Surname,
                StudentID=value.StudentID
            };
            
        }
    }
}
