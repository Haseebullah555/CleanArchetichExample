using Application.DTOs.Subject;
using MediatR;

namespace Application.Features.Subjects.Request.Command
{
    public class UpdateSubjectCommand : IRequest<int>
    {
        public SubjectDto subjectDto { get; set; }
    }
}
