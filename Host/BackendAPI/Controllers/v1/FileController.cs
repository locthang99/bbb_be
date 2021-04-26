using Application.Features.Account.Base.Queries;
using Application.Features.Account.EndUser.Commands;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    [ApiController]
    public class FileController : BaseApiController
    {

        [HttpGet("Images/{nameFile}")]
        public FileContentResult GetFileImage(string nameFile)
        {
            var myfile = System.IO.File.ReadAllBytes("wwwroot/Image/" + nameFile);
            return new FileContentResult(myfile, "image/jpg");
        }
        [HttpGet("Musics/{nameFile}")]
        public FileContentResult GetFileMusic(string nameFile)
        {
            var myfile = System.IO.File.ReadAllBytes("wwwroot/Audio/" + nameFile);
            return new FileContentResult(myfile, "audio/mpeg");

        }
        [HttpGet("Lyrics/{nameFile}")]
        public FileContentResult GetFileLyric(string nameFile)
        {
            var myfile = System.IO.File.ReadAllBytes("wwwroot/Lyric/" + nameFile);
            return new FileContentResult(myfile, "application/text");

        }
    }
}
