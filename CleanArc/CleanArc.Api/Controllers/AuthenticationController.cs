using CleanArc.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace CleanArc.Api.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterRequest request)
        {
            //var response = await _authenticationService.RegisterAsync(request);
            return Ok(request);
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            //var response = await _authenticationService.LoginAsync(request);
            return Ok(request);
        }
    }
}
