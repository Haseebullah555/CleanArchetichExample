using Application.Features.Registration.Request.Query;
using AutoMapper;
using Domain.IdentityEntities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Registration.Handler.Query
{
    public class GetAllUserRequestHandler : IRequestHandler<GetAllUserRequest, List<ApplicationUser>>
    {
        private readonly UserManager<ApplicationUser> _usermanager;

        public GetAllUserRequestHandler(UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            _usermanager = userManager;
        }
        public async Task<List<ApplicationUser>> Handle(GetAllUserRequest request, CancellationToken cancellationToken)
        {
            var users = await _usermanager.Users.ToListAsync();
            return users;
        }
    }
}
