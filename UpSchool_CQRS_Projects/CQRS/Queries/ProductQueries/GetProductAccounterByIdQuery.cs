namespace UpSchool_CQRS_Projects.CQRS.Queries.ProductQueries
{
    public class GetProductAccounterByIdQuery
    {
        public GetProductAccounterByIdQuery(int ıd)
        {
            Id = ıd;
        }
        public int Id { get; set; }
    }
}
