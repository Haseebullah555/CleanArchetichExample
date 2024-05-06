using Application.DTOs.Student;
using Application.DTOs.Subject;
using Application.Features.Student.Request.Command;
using Application.Features.Students.Request.Command;
using Application.Features.Subjects.Request.Command;
using AutoMapper;
using Domain.Models;

namespace Application.Profiles.Student
{
    public class SubjectMappingProfile : Profile
    {
        public SubjectMappingProfile()
        {
            CreateMap<SubjectModel, SubjectDto>().ReverseMap();
            CreateMap<SubjectModel, CreateSubjectDto>().ReverseMap();
            CreateMap<SubjectModel, CreateSubjectCommand>().ReverseMap();
            CreateMap<SubjectModel, UpdateSubjectCommand>().ReverseMap();
        }
    }
}
