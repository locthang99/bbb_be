using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Type.TypeRequest
{
    public class TypeCreateRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFile Thumbnail { get; set; }
    }
}
