using UpSchool_CQRS_Projects.CQRS.Commands.ProductCommands;
using UpSchool_CQRS_Projects.DAL.Context;
using UpSchool_CQRS_Projects.DAL.Entities;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.ProductHandler
{
    public class CreateProductCommandHandler
    {
        private readonly ProductContext _productContext;

        public CreateProductCommandHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public void Handle(CreateProductCommand command)
        {
            _productContext.Products.Add(new Product
            {
                Brand = command.Brand,
                Cost = command.Cost,
                Name = command.Name,
                Stock = command.Stock,
                Tax = command.Tax,
                PurchasePirce = command.PurchasePirce,
                SalePrice = command.SalePrice,
                Size = command.Size,
                EndOfDate = command.EndOfDate,
                ProduceOfDate = command.ProduceOfDate,
                Status = true
            });
            _productContext.SaveChanges();
        }
    }

}
