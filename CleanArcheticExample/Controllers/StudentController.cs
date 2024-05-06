using Application.DTOs.Student;
using Application.Features.Student.Request.Command;
using Application.Features.Students.Request.Query;
using Application.Features.Students.Request.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Features.Student.Request.Query;

namespace CleanArcheticExample.Controllers
{
    public class StudentController : Controller
    {
        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IActionResult> AllStudents()
        {
            var students = await  _mediator.Send(new GetAllStudentsRequest());
            return View(students);
        }
        [HttpGet]
        public async Task<IActionResult> CreateStudent()
        {
            return View();
        }   
        public async Task<IActionResult> CreateStudent(CreateStudentDto studentDto)
        {
            var CreateStudent = new CreateStudentCommand { CreateStudentDto = studentDto };
            await _mediator.Send(CreateStudent);
            return RedirectToAction("AllStudents");
        }
        public async Task<IActionResult> Edit(int id)
        {
            var student = _mediator.Send(new GetStudentDetialsRequest { Id = id }).Result;
            return View(student);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(StudentDto studentDto)
        {
            if(!ModelState.IsValid)
            {
                return NotFound();
            }
            var updateStudent = new UpdateStudentCommand { studentDto = studentDto };
            await _mediator.Send(updateStudent);
            return RedirectToAction("AllStudents");
        }
        public async Task<IActionResult> Details(int id)
        {
            var student = _mediator.Send(new GetStudentDetialsRequest { Id= id }).Result;
            return View(student);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var student = _mediator.Send(new GetStudentDetialsRequest { Id = id }).Result;
            return View(student);
        }
        [ActionName("Delete"), HttpPost]
        public async Task<IActionResult> DeleteConfirmed(StudentDto studentDto)
        {
            var deleteStudent = new DeleteStudentCommand { studentDto = studentDto };
            await _mediator.Send(deleteStudent);
            return RedirectToAction("AllStudents");
        }
    }
}
