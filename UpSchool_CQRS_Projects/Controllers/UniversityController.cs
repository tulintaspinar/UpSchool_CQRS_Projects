using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UpSchool_CQRS_Projects.CQRS.Commands.UniversityCommand;
using UpSchool_CQRS_Projects.CQRS.Queries.UniversityQueries;

namespace UpSchool_CQRS_Projects.Controllers
{
    public class UniversityController : Controller
    {
        private readonly IMediator _mediator;

        public UniversityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllUniversityQuery());
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var values=await _mediator.Send(new GetUniversityByIdQuery(id));
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateUniversityCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(CreateUniversityCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new RemoveUniversityCommand(id));
            return RedirectToAction("Index");
        }
    }
}
