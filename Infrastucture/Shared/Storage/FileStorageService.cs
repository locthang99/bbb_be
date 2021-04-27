using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using ThirdPartyServices.Storage;
using Microsoft.Extensions.Hosting;


namespace ThirdPartyServices.Storage
{
    public class FileStorageService : IStorageService
    {
        private readonly string _audio;
        private const string AUDIO_FOLDER_NAME = "Audio";

        private readonly string _image;
        private const string IMAGE_FOLDER_NAME = "Image";

        private readonly string _lyric;
        private const string LYRIC_FOLDER_NAME = "Lyric";

        public FileStorageService(IHostEnvironment webHostEnvironment)
        {
            _audio = Path.Combine(webHostEnvironment.ContentRootPath + "/wwwroot", AUDIO_FOLDER_NAME);
            _image = Path.Combine(webHostEnvironment.ContentRootPath + "/wwwroot", IMAGE_FOLDER_NAME);
            _lyric = Path.Combine(webHostEnvironment.ContentRootPath + "/wwwroot", LYRIC_FOLDER_NAME);
        }

        //public string GetFileUrl(string fileName)
        //{
        //    return $"/{USER_CONTENT_FOLDER_NAME}/{fileName}";
        //}

        public async Task SaveFileAsync(Stream mediaBinaryStream, string fileName, int Type)
        {
            string filePath = "";
            if (Type == 0)
                filePath = Path.Combine(_image, fileName);
            else
                if (Type == 1)
                filePath = Path.Combine(_audio, fileName);
            else
                filePath = Path.Combine(_lyric, fileName);
            using var output = new FileStream(filePath, FileMode.Create);
            await mediaBinaryStream.CopyToAsync(output);
        }

        public async Task DeleteFileAsync(string fileName, int Type)
        {
            string filePath = "";
            if (Type == 0)
                filePath = Path.Combine(_image, fileName);
            else
                if (Type == 1)
                    filePath = Path.Combine(_audio, fileName);
                else
                    filePath = Path.Combine(_lyric, fileName);

            if (File.Exists(filePath))
            {
                await Task.Run(() => File.Delete(filePath));
            }
        }
        public async Task<string> SaveFile(IFormFile file, int Type)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await SaveFileAsync(file.OpenReadStream(), fileName, Type);
            return fileName;
        }
    }
}