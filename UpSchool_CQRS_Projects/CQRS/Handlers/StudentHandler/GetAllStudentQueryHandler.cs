using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using UpSchool_CQRS_Projects.CQRS.Results.StudentResults;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.StudentHandler
{
    public class GetAllStudentQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetAllStudentQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public List<GetAllStudentQueryResult> Handle()
        {
            var values = _productContext.Students.Select(x => new GetAllStudentQueryResult
            {
                City= x.City,
                Department= x.Department,
                Name= x.Name,
                StudentID= x.StudentID,
                Surname=x.Surname
            }).AsNoTracking().ToList();
            return values;
        }
    }
}
