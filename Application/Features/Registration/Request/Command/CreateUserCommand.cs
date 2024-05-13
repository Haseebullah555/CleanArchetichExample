using Application.DTOs.Registeration;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Registration.Request.Command
{
    public class CreateUserCommand : IRequest<IdentityResult>
    {
        public RegisterUserDto? User { get; set; }
    }
}
