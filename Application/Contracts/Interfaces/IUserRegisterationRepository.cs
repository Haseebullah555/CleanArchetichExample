using Domain.IdentityEntities;

namespace Application.Contracts.Interfaces
{
    public interface IUserRegisterationRepository
    {
        Task<List<ApplicationUser>> GetAll();
        Task<ApplicationUser> GetById(string id);
        Task Insert(ApplicationUser applicationUser);
        Task Update(ApplicationUser applicationUser);
        Task Delete(ApplicationUser applicationUser);
    }
}
