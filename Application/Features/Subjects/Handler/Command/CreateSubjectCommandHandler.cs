using Application.Contracts.Interfaces;
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
    public class CreateSubjectCommandHandler : IRequestHandler<CreateSubjectCommand, int>
    {
        private readonly IUnitOfWork _UoW;
        private readonly IMapper _mapper;

        public CreateSubjectCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _UoW = unitOfWork;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateSubjectCommand request, CancellationToken cancellationToken)
        {
            var student = _mapper.Map<SubjectModel>(request.CreateSubjectDto);
            await _UoW.SubjectRepository.Insert(student);
            _UoW.Complete();
            return student.Id;
        }
    }
}
