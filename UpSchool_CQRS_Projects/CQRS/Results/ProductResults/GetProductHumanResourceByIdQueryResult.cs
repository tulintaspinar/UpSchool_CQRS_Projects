namespace UpSchool_CQRS_Projects.CQRS.Results.ProductResults
{
    public class GetProductHumanResourceByIdQueryResult
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal SalePrice { get; set; }
    }
}
