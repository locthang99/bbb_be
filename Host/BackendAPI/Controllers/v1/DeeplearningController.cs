using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Application.Wrappers;
using ThirdPartyServices.Deeplearning;
using ThirdPartyServices.Deeplearning.DTO;
//using Application.Features.Tag.Commands;

namespace BackendAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    public class DeeplearningController : BaseApiController
    {
        #region Queries
        private readonly IDeeplearningService _deeplearningService;
        public DeeplearningController(IDeeplearningService deeplearningService)
        {
            _deeplearningService = deeplearningService;
        }

        [HttpGet("GetModels")]
        public async Task<IActionResult> GetModels()
        {
            var rs = await _deeplearningService.GetModels();
            return Ok(new Response<object>() { Msg = "Get models OK", Data = rs });
        }

        [HttpPost("SetConfigHost")]
        public async Task<IActionResult> GetChartSong([FromQuery] string host)
        {
            var rs = await _deeplearningService.SetConfigServer(host);
            return Ok(new Response<object>() { Msg = "Set host OK", Data = rs });
        }

        [HttpGet("GetConfigHost")]
        public async Task<IActionResult> GetConfigHost()
        {
            var rs = await _deeplearningService.GetConfigServer();
            return Ok(new Response<object>() { Msg = "Get host OK", Data = rs });
        }

        [HttpPost("SaveTempFileMusic")]
        public async Task<IActionResult> SaveTempFileMusic([FromForm] FileObj file)
        {
            var rs = await _deeplearningService.SaveTempFileMusic(file);
            return Ok(new Response<object>() { Msg = "Get host OK", Data = new { nameFile = rs } });
        }

        [HttpPost("PredictTemp_SongVN")]
        public async Task<IActionResult> PredictTemp_SongVN([FromForm] FileObj file)
        {
            var rs = await _deeplearningService.PredictTemp(file,true);
            return Ok(new Response<object>() { Msg = "Predict VN OK", Data = rs });
        }

        [HttpPost("PredictTemp_SongAU")]
        public async Task<IActionResult> PredictTemp_SongAU([FromForm] FileObj file)
        {
            var rs = await _deeplearningService.PredictTemp(file, false);
            return Ok(new Response<object>() { Msg = "Predict AU OK", Data = rs });
        }


        #endregion

        #region Command

        #endregion
    }
    }
