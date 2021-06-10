using Application.Features.Account.Base.Queries;
using Application.Features.Account.EndUser.Commands;
using Application.Wrappers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThirdPartyServices.Deeplearning.DTO;
using ThirdPartyServices.Storage;

namespace BackendAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    [ApiController]
    public class FileController : BaseApiController
    {
        private readonly IStorageService _storageService;
        public FileController(IStorageService storageService)
        {
            _storageService = storageService;
        }

        [HttpGet("Images/{nameFile}")]
        public FileContentResult GetFileImage(string nameFile)
        {
            try
            {
                var myfile = System.IO.File.ReadAllBytes("wwwroot/Image/" + nameFile);
                return new FileContentResult(myfile, "image/jpg");
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        [HttpGet("Musics/{nameFile}")]
        public FileContentResult GetFileMusic(string nameFile)
        {
            try
            {
                var myfile = System.IO.File.ReadAllBytes("wwwroot/Audio/" + nameFile);
                return new FileContentResult(myfile, "audio/mpeg");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        [HttpGet("Lyrics/{nameFile}")]
        public FileContentResult GetFileLyric(string nameFile)
        {
            try
            {
                var myfile = System.IO.File.ReadAllBytes("wwwroot/Lyric/" + nameFile);
                return new FileContentResult(myfile, "application/text");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpGet("Temp")]
        public FileContentResult GetTemp(string nameFile,string type)
        {
            try
            {
                var myfile = System.IO.File.ReadAllBytes("wwwroot/Temporary/" + nameFile);
                if(type == "audio")
                    return new FileContentResult(myfile, "audio/mpeg");
                else
                    return new FileContentResult(myfile, "image/jpg");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpPost("SaveTempFile")]
        public async Task<ActionResult>  SaveTempFile([FromForm] FileObj file )
        {
            try
            {
                var rs = await _storageService.SaveTempFile(file.file);
                return Ok(new Response<object>() { Msg = "Save temp file ok", Data = new { nameFile = rs } });
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
