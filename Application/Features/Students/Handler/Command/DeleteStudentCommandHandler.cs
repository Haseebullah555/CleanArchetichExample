using Application.Contracts.Interfaces;
using Application.DTOs.Student;
using Application.Features.Students.Request.Command;
using AutoMapper;
using Domain.Models;
using MediatR;

namespace Application.Features.Students.Handler.Command
{
    public class DeleteStudentCommandHandler : IRequestHandler<DeleteStudentCommand, Unit>
    {
        private readonly IUnitOfWork _UoW;
        private readonly IMapper _mapper;

        public DeleteStudentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _UoW = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            var result = await _UoW.StudentRepository.GetById(request.studentDto.Id);
            var student = _mapper.Map<StudentDto, StudentModel>(request.studentDto,result);
            await _UoW.StudentRepository.Delete(student);
            _UoW.Complete();
            return Unit.Value;
        }
    }
}
