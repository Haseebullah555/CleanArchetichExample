using Application.Contracts.Interfaces;
using Application.DTOs.Subject;
using Application.Features.Subjects.Request.Command;
using AutoMapper;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Subjects.Handler.Command
{
    public class DeleteSubjectCommandHandler : IRequestHandler<DeleteSubjectCommand, Unit>
    {
        private readonly IUnitOfWork _UoW;
        private readonly IMapper _mapper;

        public DeleteSubjectCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _UoW = unitOfWork;
            _mapper = mapper;

        }
        public async Task<Unit> Handle(DeleteSubjectCommand request, CancellationToken cancellationToken)
        {
            var result = await _UoW.SubjectRepository.GetById(request.subjectDto.Id);
            var subject = _mapper.Map<SubjectDto, SubjectModel>(request.subjectDto, result);
            await _UoW.SubjectRepository.Update(subject);
            _UoW.Complete();
            return Unit.Value;
        }
    }
}
