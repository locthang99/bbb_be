using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.FileImage
{
    public class FileImageDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Path { get; set; }
        public long FileSize { get; set; }
    }
}
