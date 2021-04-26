using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Type.TypeRequest
{
    public class TypeUpdateRequest
    {
        //public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFile Thumbnail { get; set; }
    }
}
