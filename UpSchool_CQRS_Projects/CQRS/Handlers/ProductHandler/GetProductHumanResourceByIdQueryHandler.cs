using UpSchool_CQRS_Projects.CQRS.Queries.ProductQueries;
using UpSchool_CQRS_Projects.CQRS.Results.ProductResults;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.ProductHandler
{
    public class GetProductHumanResourceByIdQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductHumanResourceByIdQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public GetProductHumanResourceByIdQueryResult Handle(GetProductHumanResourceByIdQuery query)
        {
            var values = _productContext.Products.Find(query.Id);
            return new GetProductHumanResourceByIdQueryResult
            {
                ProductID = values.ProductID,
                Name = values.Name,
                Brand = values.Brand,
                SalePrice = values.SalePrice
            };
        }
    }
}
