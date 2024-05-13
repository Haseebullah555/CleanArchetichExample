using Domain.IdentityEntities;
using MediatR;

namespace Application.Features.Registration.Request.Query
{
    public class GetAllUserRequest : IRequest<List<ApplicationUser>>
    {
    }
}
