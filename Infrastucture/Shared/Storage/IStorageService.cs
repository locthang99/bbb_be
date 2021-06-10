using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ThirdPartyServices.Storage
{
    public interface IStorageService
    {
        //string GetFileUrl(string fileName);
        Task SaveFileAsync(Stream mediaBinaryStream, string fileName, int Type);//0 Image, 1 Audio
        Task DeleteFileAsync(string fileName, int Type);//0 Image, 1 Audio
        Task<string> SaveFile(IFormFile file, int Type);//0 Image, 1 Audio
        Task<string> SaveTempFile(IFormFile file);

    }
}
