using Application.DTOs.Registeration;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Application.Features.Registration.Request.Command
{
    public class CreateUserCommand : IRequest<IdentityResult>
    {
        public RegisterUserDto? User { get; set; }
    }
}
