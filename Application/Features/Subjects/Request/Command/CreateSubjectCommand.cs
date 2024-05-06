using Application.DTOs.Subject;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Subjects.Request.Command
{
    public class CreateSubjectCommand : IRequest<int>
    {
        public CreateSubjectDto createSubjectDto { get; set; }
    }
}
