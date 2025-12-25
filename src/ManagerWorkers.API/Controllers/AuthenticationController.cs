using ManagerWorkers.Application.DataTransferObjects;
using ManagerWorkers.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ManagerWorkers.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {

        /* ****  PROPRIEDADES   **** */
        public readonly AuthService _authService;


        public AuthenticationController(AuthService authService)
        {
            this._authService = authService;
        }

        [HttpPost("login")]
        public ActionResult Login(LoginDTO loginDados)
        {
            try
            {
                _authService.UserAuthentication(loginDados);
                return Ok();
            }
            catch (Exception ex)
            {
                return Unauthorized(new { error = ex.Message });
            }

        }

        [HttpPost("register")]
        public ActionResult Register()
        {
            return Ok();
        }



    }
}
