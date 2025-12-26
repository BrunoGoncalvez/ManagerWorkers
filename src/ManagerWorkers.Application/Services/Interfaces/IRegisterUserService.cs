
using ManagerWorkers.Application.DataTransferObjects;

namespace ManagerWorkers.Application.Services.Interfaces
{
    public interface IRegisterUserService
    {

        void RegisterUser(RegisterUserDTO user);

    }
}
