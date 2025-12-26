
using ManagerWorkers.Application.DataTransferObjects;

namespace ManagerWorkers.Application.Services.Interfaces
{
    public interface ILoginService 
    {

        void UserAuthentication(LoginDTO loginDados);

    }
}
