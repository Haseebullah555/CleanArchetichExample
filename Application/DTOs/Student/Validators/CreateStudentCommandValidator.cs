using Application.Features.Student.Request.Command;
using FluentValidation;

namespace Application.DTOs.Student.Validators
{
    public class CreateStudentCommandValidator : AbstractValidator<CreateStudentCommand>
    {
        //public CreateStudentCommandValidator()
        //{
        //    RuleFor(s => s.Email).NotEmpty()
        //        .WithMessage("{PropertyName} is required")
        //        .NotNull()
        //        .MaximumLength(60).WithMessage("{PropertyName} maximum length is 60 character");
        //}
    }
}
