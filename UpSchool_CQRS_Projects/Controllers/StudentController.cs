using Microsoft.AspNetCore.Mvc;
using UpSchool_CQRS_Projects.CQRS.Commands.StudentCommands;
using UpSchool_CQRS_Projects.CQRS.Handlers.StudentHandler;
using UpSchool_CQRS_Projects.CQRS.Queries.StudentQueries;

namespace UpSchool_CQRS_Projects.Controllers
{
    public class StudentController : Controller
    {
        private readonly CreateStudentCommandHandler _createStudentCommandHandler;
        private readonly GetAllStudentQueryHandler _getAllStudentQueryHandler;
        private readonly RemoveStudentCommandHandler _removeStudentCommandHandler;
        private readonly GetStudentByIdQueryHandler _getStudentByIdQueryHandler;
        private readonly UpdateStudentCommandHandler _updateStudentCommandHandler;
        public StudentController(CreateStudentCommandHandler createStudentCommandHandler, GetAllStudentQueryHandler getAllStudentQueryHandler, RemoveStudentCommandHandler removeStudentCommandHandler, GetStudentByIdQueryHandler getStudentByIdQueryHandler, UpdateStudentCommandHandler updateStudentCommandHandler)
        {
            _createStudentCommandHandler = createStudentCommandHandler;
            _getAllStudentQueryHandler = getAllStudentQueryHandler;
            _removeStudentCommandHandler = removeStudentCommandHandler;
            _getStudentByIdQueryHandler = getStudentByIdQueryHandler;
            _updateStudentCommandHandler = updateStudentCommandHandler;
        }
        public IActionResult Index()
        {
            var values = _getAllStudentQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(CreateStudentCommand command)
        {
            _createStudentCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteStudent(int id)
        {
            _removeStudentCommandHandler.Handle(new RemoveStudentCommand(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {
            var value = _getStudentByIdQueryHandler.Handle(new GetStudentByIdQuery(id));
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateStudent(UpdateStudentCommand command)
        {
            _updateStudentCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

            [HttpGet]
        public IActionResult DetailStudent()
        {
            return View();
        }
    }
}
