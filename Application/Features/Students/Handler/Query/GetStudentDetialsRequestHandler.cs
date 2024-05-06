using Application.Contracts.Interfaces;
using Application.DTOs.Student;
using Application.Features.Students.Request.Query;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Students.Handler.Query
{
    public class GetStudentDetialsRequestHandler : IRequestHandler<GetStudentDetialsRequest, StudentDto>
    {
        private readonly IUnitOfWork _UoW;
        private readonly IMapper _mapper;

        public GetStudentDetialsRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _UoW = unitOfWork;
            _mapper = mapper;
            
        }
        public async Task<StudentDto> Handle(GetStudentDetialsRequest request, CancellationToken cancellationToken)
        {
            var student = await _UoW.StudentRepository.GetById(request.Id);
            return _mapper.Map<StudentDto>(student);
        }
    }
}
