using Application.DTOs.Student;
using Application.DTOs.Subject;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Student.Request.Query
{
    public class GetAllStudentsRequest : IRequest<List<StudentDto>>
    {
    }
}
