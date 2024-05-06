using Application.Contracts.Interfaces;
using Application.DTOs.Subject;
using Application.Features.Subjects.Request.Query;
using AutoMapper;
using Domain.Models;
using MediatR;

namespace Application.Features.Subjects.Handler.Query
{
    public class GetAllSubjectsRequestHandler : IRequestHandler<GetAllSubjectsRequest, List<SubjectDto>>
    {
        private readonly IUnitOfWork _UoW;
        private readonly IMapper _mapper;

        public GetAllSubjectsRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _UoW = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<SubjectDto>> Handle(GetAllSubjectsRequest request, CancellationToken cancellationToken)
        {
            var subjects = await _UoW.SubjectRepository.GetAll();
            return  _mapper.Map<List<SubjectDto>>(subjects);
        }
    }
}
