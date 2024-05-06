using Application.DTOs.Student;
using Application.Features.Student.Request.Query;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchetichExample.Controllers
{
    public class StudentController : Controller
    {
        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public Task<List<StudentDto>> AllStudent()
        {
            return _mediator.Send(new GetAllStudentRequest());
        }
    }
}
