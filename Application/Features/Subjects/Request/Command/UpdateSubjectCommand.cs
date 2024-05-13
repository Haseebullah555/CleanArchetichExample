using Application.DTOs.Subject;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Features.Subjects.Request.Command
{
    public class UpdateSubjectCommand : IRequest<int>
    {
        public SubjectDto? SubjectDto { get; set; }
    }
}
