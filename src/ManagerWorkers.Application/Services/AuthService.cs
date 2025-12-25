using ManagerWorkers.Application.DataTransferObjects;
using System;

namespace ManagerWorkers.Application.Services
{
    public class AuthService
    {

        public AuthService() { }


        public void UserAuthentication(LoginDTO dados) 
        {
            // validação fake de exemplo
            if (dados.Email != "admin@email.com" || dados.Password != "123")
                throw new Exception("Usuário ou senha inválidos");
        }

    }
}
