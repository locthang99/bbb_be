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
    }
}
