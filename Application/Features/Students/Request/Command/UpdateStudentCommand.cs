using Application.DTOs.Student;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Students.Request.Command
{
    public class UpdateStudentCommand : IRequest<int>
    {
        public StudentDto? StudentDto {  get; set; }
    }
}
