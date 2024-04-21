using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.Upload;
using Melody.BusinessLayer.Strategies;
using Melody.Shared.Enums;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;

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
        public async Task<IActionResult> UploadAudio(CancellationToken cancellationToken)
        {
            var formCollection = await Request.ReadFormAsync(cancellationToken);

            var uploadRequest = new UploadAudioRequest
            {
                Data = JsonConvert.DeserializeObject<UploadAudioDataRequest>(formCollection["data"]),
                File = formCollection.Files[0]
            };

            var result = await _uploadService.UploadAudioAsync(uploadRequest, cancellationToken);

            if (result.IsSuccess)
            {
                return Ok();
            }
            
            return BadRequest();
        }
    }
}
