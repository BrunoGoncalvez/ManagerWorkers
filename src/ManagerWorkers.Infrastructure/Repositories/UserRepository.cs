using ManagerWorkers.Core.Entities;
using ManagerWorkers.Core.Repositories;

namespace ManagerWorkers.Infrastructure.Repositories 
{
    public class UserRepository : IUserRepository
    {
        public void Add(User user)
        {
            throw new NotImplementedException();
        }

        public User GetByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
