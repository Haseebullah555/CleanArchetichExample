using Application.DTOs.Subject;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Subjects.Request.Query
{
    public class GetAllSubjectsRequest : IRequest<List<SubjectDto>>
    {
    }
}
