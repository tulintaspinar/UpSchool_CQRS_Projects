namespace UpSchool_CQRS_Projects.CQRS.Queries.ProductQueries
{
    public class GetProductHumanResourceByIdQuery
    {
        public GetProductHumanResourceByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
