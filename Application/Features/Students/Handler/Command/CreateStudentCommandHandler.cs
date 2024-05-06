using Application.Contracts.Interfaces;
using Application.DTOs.Student.Validators;
using Application.Features.Student.Request.Command;
using AutoMapper;
using Domain.Models;
using MediatR;

namespace Application.Features.Student.Handler.Command
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, int>
    {
        private readonly IUnitOfWork _UoW;
        private readonly IMapper _mapper;

        public CreateStudentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _UoW = unitOfWork;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            //var validator = new CreateStudentCommandValidator();
            //var validatorResult = await validator.ValidateAsync(request);
            //if(validatorResult.IsValid == false)
            //{
            //    throw new Exception("Invalid Email Address");
            //}
            var student = _mapper.Map<StudentModel>(request.CreateStudentDto);
            await _UoW.StudentRepository.Insert(student);
            _UoW.Complete();
            return student.Id;
        }
    }
}
