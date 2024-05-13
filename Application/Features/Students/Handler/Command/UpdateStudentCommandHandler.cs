using Application.Contracts.Interfaces;
using Application.DTOs.Student;
using Application.Features.Students.Request.Command;
using AutoMapper;
using Domain.Models;
using MediatR;

namespace Application.Features.Students.Handler.Command
{
    public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand, int>
    {
        private readonly IUnitOfWork _UoW;
        private readonly IMapper _mapper;

        public UpdateStudentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _UoW = unitOfWork;
            _mapper = mapper;
        }
        public async Task<int> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var result = await _UoW.StudentRepository.GetById(request.StudentDto.Id);
            var student = _mapper.Map<StudentDto, StudentModel>(request.StudentDto, result);
            await _UoW.StudentRepository.Update(student);
            _UoW.Complete();
            return student.Id;
        }
    }
}
