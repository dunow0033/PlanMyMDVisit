using Microsoft.AspNetCore.Identity;
using planMyMDVisit.Models.Domain;

namespace planMyMDVisit.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUserById(Guid Id);
        Task<List<User>> GetAll();
    }
}
