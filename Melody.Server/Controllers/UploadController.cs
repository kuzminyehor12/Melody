using Melody.Server.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Melody.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> UploadAudio(UploadAudioRequest request, CancellationToken cancellationToken)
        {
            await Task.Delay(5000);
            return Ok();
        }
    }
}
