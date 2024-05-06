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
    }
}
