
using ManagerWorkers.Application.DataTransferObjects;
using ManagerWorkers.Application.Services.Interfaces;
using ManagerWorkers.Core.Entities;
using ManagerWorkers.Core.Repositories;

namespace ManagerWorkers.Application.Services
{
    public class RegisterUserService : IRegisterUserService
    {

        private readonly IUserRepository _userRepository;

        public RegisterUserService(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public void RegisterUser(RegisterUserDTO dto)
        {
            var existingUser = this._userRepository.GetByEmail(dto.Email);

            if (existingUser != null)
                throw new ApplicationException("Usuário já cadastrado");

            var user = new User(dto.Name, dto.Email);

            // senha virá depois (hash etc.)
            this._userRepository.Add(user);
        }
    }
}
