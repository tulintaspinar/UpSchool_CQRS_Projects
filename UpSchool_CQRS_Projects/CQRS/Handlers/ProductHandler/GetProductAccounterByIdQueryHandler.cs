using UpSchool_CQRS_Projects.CQRS.Queries.ProductQueries;
using UpSchool_CQRS_Projects.CQRS.Results.ProductResults;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.ProductHandler
{
    public class GetProductAccounterByIdQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductAccounterByIdQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public GetProductAccounterByIdQueryResult Handle(GetProductAccounterByIdQuery query)
        {
            var values = _productContext.Products.Find(query.Id);
            return new GetProductAccounterByIdQueryResult
            {
                ProductID=values.ProductID,
                Name=values.Name,
                Brand=values.Brand,
                Description=values.Description,
                PurchasePirce=values.PurchasePirce,
                SalePrice=values.SalePrice,
                Stock=values.Stock,
                Tax = values.Tax
            };
        }
    }
}
