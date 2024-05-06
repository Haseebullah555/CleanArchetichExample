using Application.Contracts.Interfaces;
using Application.DTOs.Subject;
using Application.Features.Subjects.Request.Command;
using AutoMapper;
using Domain.Models;
using MediatR;

namespace Application.Features.Subjects.Handler.Command
{
    public class UpdateSubjectCommandHandler : IRequestHandler<UpdateSubjectCommand, int>
    {
        private readonly IUnitOfWork _UoW;
        private readonly IMapper _mapper;

        public UpdateSubjectCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _UoW = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(UpdateSubjectCommand request, CancellationToken cancellationToken)
        {
            var result = await _UoW.SubjectRepository.GetById(request.subjectDto.Id);
            var subject = _mapper.Map<SubjectDto, SubjectModel>(request.subjectDto, result);
            await _UoW.SubjectRepository.Update(subject);
            _UoW.Complete();
            return subject.Id;
        }
    }
}
