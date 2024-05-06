using Application.DTOs.Student;
using MediatR;

namespace Application.Features.Students.Request.Command
{
    public class DeleteStudentCommand : IRequest<Unit>
    {
        public StudentDto studentDto { get; set; }
    }
}
