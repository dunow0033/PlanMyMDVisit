using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using planMyMDVisit.Data;

namespace planMyMDVisit.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly PlanMyMDVisitContext planMyMDContext;

        public UserRepository(PlanMyMDVisitContext planMyMDContext)
        {
            this.planMyMDContext = planMyMDContext;
        }

        public async Task<IEnumerable<IdentityUser>> GetAll()
        {
            var users = await planMyMDContext.Users.ToListAsync();

            //var superAdminUser = await authDbContext.Users
            //    .FirstOrDefaultAsync(x => x.Email == "superadmin@bloggie.com");

            //if (superAdminUser is not null)
            //{
            //    users.Remove(superAdminUser);
            //}

            return users;
        }
    }
}
