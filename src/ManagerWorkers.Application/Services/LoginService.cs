using ManagerWorkers.Application.DataTransferObjects;
using ManagerWorkers.Application.Services.Interfaces;
using System;

namespace ManagerWorkers.Application.Services
{
    public class LoginService : ILoginService
    {

        public LoginService() { }

        

        public void UserAuthentication(LoginDTO dados) 
        {
            if (dados.Email != "admin@email.com" || dados.Password != "123")
                throw new Exception("Usuário ou senha inválidos");
        }

        public void RegisterUser(RegisterUserDTO user)
        {
            throw new NotImplementedException();
        }

    }
}
