using Application.DTOs.Subject;
using Application.Features.Subjects.Request.Command;
using Application.Features.Subjects.Request.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArcheticExample.Controllers
{
    public class SubjectController(IMediator mediator) : Controller
    {
        private readonly IMediator _mediator = mediator;

        public async Task<IActionResult> Index()
        {
            var students = await _mediator.Send(new GetAllSubjectsRequest());
            return View(students);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateSubjectDto createSubjectDto)
        {
            if (ModelState.IsValid == false)
            {
                return NotFound();
            }
            var CreateSubject = new CreateSubjectCommand { CreateSubjectDto = createSubjectDto };
            await _mediator.Send(CreateSubject);
            return RedirectToAction("Index");
        }
    }
}
