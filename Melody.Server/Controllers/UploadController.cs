using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.Upload;
using Microsoft.AspNetCore.Mvc;

namespace Melody.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        private readonly IUploadService _uploadService;

        public UploadController(IUploadService uploadService)
        {
            _uploadService = uploadService;
        }

        [HttpPost]
        public async Task<IActionResult> UploadAudio(UploadAudioRequest request, CancellationToken cancellationToken)
        {
            var result = await _uploadService.UploadAudioAsync(request, cancellationToken);

            if (result.IsSuccess)
            {
                return Ok();
            }

            return BadRequest();
        }
    }
}
