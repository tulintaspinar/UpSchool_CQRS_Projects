using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using UpSchool_CQRS_Projects.CQRS.Queries.ProductQueries;
using UpSchool_CQRS_Projects.CQRS.Results.ProductResults;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.ProductHandler
{
    public class GetProductAccounterQeuryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductAccounterQeuryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public List<GetProductAccounterQeuryResult> Handle()
        {
            var values = _productContext.Products.Select(x => new GetProductAccounterQeuryResult
            {
                ProductID=x.ProductID,
                Name=x.Name,
                Stock=x.Stock,
                Brand=x.Brand,
                Tax=x.Tax,
                SalePrice=x.SalePrice,
                PurchasePirce=x.PurchasePirce
            }).AsNoTracking().ToList(); //AsNoTracking : Sorgunun performansını arttırıyor. Sadece get işlemi yapıldığı için takibe gerek yok
            return values;
        }
    }
}
