using Application.DTOs.Student;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Student.Request.Command
{
    public class CreateStudentCommand : IRequest<int>
    {
        public CreateStudentDto CreateStudentDto { get; set; }
    }
}
