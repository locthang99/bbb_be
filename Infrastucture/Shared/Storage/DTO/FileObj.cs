using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdPartyServices.Storage.DTO
{
    public class FileObj
    {
        public IFormFile file { get; set; }
    }
}
