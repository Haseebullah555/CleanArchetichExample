using Application.DTOs.Registeration;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Registration.Request.Query
{
    public class GetAllUserRequest : IRequest<List<UserRegisterDto>>
    {
    }
}
