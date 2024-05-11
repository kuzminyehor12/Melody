using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.Auth;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Melody.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserRequest request, CancellationToken cancellationToken)
        {
            var result = await _authService.RegisterAsync(request, cancellationToken);

            if (result.IsFailure)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }
    }
}
