using Application.Contracts.Interfaces;
using Application.DTOs.Subject;
using Application.Features.Subjects.Request.Query;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Subjects.Handler.Query
{
    public class GetSubjectDetailsRequestHandler : IRequestHandler<GetSubjectDetailsRequest, SubjectDto>
    {
        private readonly IUnitOfWork _UoW;
        private readonly IMapper _mapper;

        public GetSubjectDetailsRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _UoW = unitOfWork;
            _mapper = mapper;
        }
        public async Task<SubjectDto> Handle(GetSubjectDetailsRequest request, CancellationToken cancellationToken)
        {
            var subject = await _UoW.SubjectRepository.GetById(request.Id);
            return _mapper.Map<SubjectDto>(subject);
        }
    }
}
