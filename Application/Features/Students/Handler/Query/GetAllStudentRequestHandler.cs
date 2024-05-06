using Application.Contracts.Interfaces;
using Application.DTOs.Student;
using Application.Features.Student.Request.Query;
using AutoMapper;
using MediatR;

namespace Application.Features.Student.Handler.Query
{
    public class GetAllStudentRequestHandler : IRequestHandler<GetAllStudentsRequest, List<StudentDto>>
    {
        private readonly IUnitOfWork _UoW;
        private readonly IMapper _mapper;

        public GetAllStudentRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _UoW = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<StudentDto>> Handle(GetAllStudentsRequest request, CancellationToken cancellationToken)
        {
            var students = await _UoW.StudentRepository.GetAll();
               //.GetStudents();
            return  _mapper.Map<List<StudentDto>>(students);
        }
    }
}
