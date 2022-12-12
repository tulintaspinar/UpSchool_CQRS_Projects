using Microsoft.AspNetCore.Mvc;
using UpSchool_CQRS_Projects.CQRS.Commands.ProductCommands;
using UpSchool_CQRS_Projects.CQRS.Handlers.ProductHandler;
using UpSchool_CQRS_Projects.CQRS.Queries.ProductQueries;

namespace UpSchool_CQRS_Projects.Controllers
{
    public class ProductController : Controller
    {
        private readonly GetProductAccounterQeuryHandler _getProductAccounterQeuryHandler;
        private readonly GetProductStoragerQueryHandler _getProductStoragerQueryHandler;
        private readonly GetProductHumanResourceByIdQueryHandler _getProductHumanResourceByIdQueryHandler;
        private readonly GetProductAccounterByIdQueryHandler _getProductAccounterByIdQueryHandler;
        private readonly CreateProductCommandHandler _createProductCommandHandler;

        public ProductController(GetProductAccounterQeuryHandler getProductAccounterQeuryHandler, GetProductStoragerQueryHandler getProductStoragerQueryHandler, GetProductHumanResourceByIdQueryHandler getProductHumanResourceByIdQueryHandler, GetProductAccounterByIdQueryHandler getProductAccounterByIdQueryHandler, CreateProductCommandHandler createProductCommandHandler)
        {
            _getProductAccounterQeuryHandler = getProductAccounterQeuryHandler;
            _getProductStoragerQueryHandler = getProductStoragerQueryHandler;
            _getProductHumanResourceByIdQueryHandler = getProductHumanResourceByIdQueryHandler;
            _getProductAccounterByIdQueryHandler = getProductAccounterByIdQueryHandler;
            _createProductCommandHandler = createProductCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _getProductAccounterQeuryHandler.Handle();
            return View(values);
        }
        public IActionResult StoragerIndex()
        {
            var values = _getProductStoragerQueryHandler.Handle();
            return View(values);
        }

        public IActionResult GetHumanResourceIndex(int id)
        {
            var value = _getProductHumanResourceByIdQueryHandler.Handle(new GetProductHumanResourceByIdQuery(id));
            return View(value);
        }
        public IActionResult AccounterIndexById(int id)
        {
            var value = _getProductAccounterByIdQueryHandler.Handle(new GetProductAccounterByIdQuery(id));
            return View(value);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand command)
        {
            _createProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
