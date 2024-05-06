using Application.DTOs.Student;
using Application.Features.Student.Request.Command;
using Application.Features.Students.Request.Command;
using AutoMapper;
using Domain.Models;

namespace Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<StudentModel, StudentDto>().ReverseMap();
            CreateMap<StudentModel, CreateStudentDto>().ReverseMap();
            CreateMap<StudentModel, CreateStudentCommand>().ReverseMap();
            CreateMap<StudentModel, UpdateStudentCommand>().ReverseMap();
        }
    }
}
