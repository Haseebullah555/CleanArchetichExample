using Application.DTOs.Subject;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Subjects.Request.Command
{
    public class DeleteSubjectCommand : IRequest<Unit>
    {
        public SubjectDto? SubjectDto { get; set; }
    }
}
