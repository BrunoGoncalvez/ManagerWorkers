using ManagerWorkers.Application.DataTransferObjects;
using ManagerWorkers.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ManagerWorkers.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {

        /* ****  PROPRIEDADES   **** */
        private readonly ILoginService _loginService;
        private readonly IRegisterUserService _registerUserService;


        public AuthenticationController(ILoginService loginService, IRegisterUserService registerUserService)
        {
            this._loginService = loginService;
            this._registerUserService = registerUserService;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginDTO loginDados)
        {
            this._loginService.UserAuthentication(loginDados);
            return Ok();
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterUserDTO user)
        {
            this._registerUserService.RegisterUser(user);
            return Ok();
        }

    }
}
