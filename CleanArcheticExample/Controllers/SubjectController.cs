using Application.DTOs.Subject;
using Application.Features.Subjects.Request.Command;
using Application.Features.Subjects.Request.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArcheticExample.Controllers
{
    public class SubjectController : Controller
    {
        private readonly IMediator _mediator;

        public SubjectController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IActionResult> Index()
        {
            var students = await _mediator.Send(new GetAllSubjectsRequest());
            return View(students);
        }
        public async Task<IActionResult> Create()
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
            var CreateSubject = new CreateSubjectCommand { createSubjectDto = createSubjectDto };
            await _mediator.Send(CreateSubject);
            return RedirectToAction("Index");
        }
    }
}
