using Application.Contracts.Interfaces;
using Application.Features.Registration.Request.Command;
using AutoMapper;
using Domain.IdentityEntities;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Application.Features.Registration.Handler.Command
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, IdentityResult>
    {
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUnitOfWork _UoW;

        public CreateUserCommandHandler(UserManager<ApplicationUser> userManager, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _userManager = userManager;
            _UoW = unitOfWork;
        }
        public async Task<IdentityResult> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<ApplicationUser>(request.User);
            IdentityResult result = await _userManager.CreateAsync(user);
            _UoW.Complete();
            return result;

        }
    }
}
