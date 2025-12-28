using ManagerWorkers.Core.Entities;

namespace ManagerWorkers.Core.Repositories
{
    public interface IUserRepository
    {

        void Add(User user);

        User GetByEmail(string email);

    }
}
