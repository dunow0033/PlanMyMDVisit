using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using planMyMDVisit.Data;
using planMyMDVisit.Models.Domain;

namespace planMyMDVisit.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly PlanMyMDVisitContext planMyMDContext;
        private readonly UserManager<User> userManager;

        public UserRepository(PlanMyMDVisitContext planMyMDContext, UserManager<User> userManager)
        {
            this.planMyMDContext = planMyMDContext;
            this.userManager = userManager;
        }

        public async Task<User> GetUserById(Guid Id)
        {
            var user = await planMyMDContext.Users
                .Include(u => u.Doctors)
                .Include(u => u.Patients)
                .FirstOrDefaultAsync(u => u.Id == Id);

            return user;
        }

        public async Task<List<User>> GetAll()
        {
            var users = await planMyMDContext.Users.ToListAsync();

            //var users = await userManager.Users.ToListAsync();

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
