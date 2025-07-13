using Microsoft.AspNetCore.Identity;

namespace planMyMDVisit.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<IdentityUser>> GetAll();
    }
}
