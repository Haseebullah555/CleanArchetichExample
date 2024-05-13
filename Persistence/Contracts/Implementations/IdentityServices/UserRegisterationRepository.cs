using Application.Contracts.Interfaces;
using AutoMapper;
using Domain.IdentityEntities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Contracts.Implementations.IdentityServices
{
    public class UserRegisterationRepository : IUserRegisterationRepository
    {
        private readonly IUnitOfWork _UoW;
        private readonly UserManager<ApplicationUser> _usermanager;
        private readonly IMapper _mapper;

        public UserRegisterationRepository(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            _UoW = unitOfWork;
            _usermanager = userManager;
            _mapper = mapper;
        }
        public Task Delete(ApplicationUser applicationUser)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ApplicationUser>> GetAll()
        {
            var users = await _usermanager.Users.ToListAsync();
            return users;
        }

        public Task<ApplicationUser> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(ApplicationUser applicationUser)
        {
            throw new NotImplementedException();
        }

        public Task Update(ApplicationUser applicationUser)
        {
            throw new NotImplementedException();
        }
    }
}
