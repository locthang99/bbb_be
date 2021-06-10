using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyServices.Deeplearning.DTO;
using ThirdPartyServices.RedisCache;
using ThirdPartyServices.Storage;
using Newtonsoft.Json;

namespace ThirdPartyServices.Deeplearning
{
    public class DeeplearningService : IDeeplearningService
    {
        private readonly IStorageService _storageService;
        private readonly IRedisService _rediservice;
        private readonly IHttpClientFactory _httpClientFactoty;
        private readonly string KEY_HOST = "host_server_deeplearning";
        public DeeplearningService(IStorageService storageService, IRedisService rediservice, IHttpClientFactory httpClientFactoty)
        {
            _storageService = storageService;
            _rediservice = rediservice;
            _httpClientFactoty = httpClientFactoty;
        }

        public async Task<string> SetConfigServer(string host)
        {
            var rs = await _rediservice.Set(new RedisCache.DTOs.ObjectCache()
            {
                db = 0,
                key = KEY_HOST,
                value = host
            });
            if (rs)
                return host;
            else
                return "SET FAILED";
        }

        public async Task<ServerInfo> GetConfigServer()
        {

            var host = await _rediservice.Get(KEY_HOST, 0);
            var proc = Process.GetCurrentProcess();
            var mem = proc.WorkingSet64;
            //var cpu = proc.TotalProcessorTime;
            return new ServerInfo()
            {
                Host = host,
                ServerName = Environment.MachineName,
                RAM = mem.ToString(),
                CPU = System.Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER")

            };
        }

        public async Task<object> PredictTemp(FileObj file,bool isVN)
        {
            var nameFile = await _storageService.SaveTempFile(file.file);
            var host = await _rediservice.Get(KEY_HOST, 0);
            var rg = isVN ? "VN" : "AU";
            var rs = await _httpClientFactoty.CreateClient().GetAsync(host+"/predict_" + rg + "/?name_file="+nameFile);
            rs.EnsureSuccessStatusCode();
            var resp = await rs.Content.ReadAsStringAsync();
            var obj = JsonConvert.DeserializeObject<List_ResponsePredict>(resp);
            return obj.data;
        }

        public async Task<string> SaveTempFileMusic(FileObj file)
        {
           var fileName = await _storageService.SaveTempFile(file.file);
            return fileName;
        }

        public async Task<List<Model>> GetModels()
        {
            var dataRedis = await _rediservice.Get("list_models", 0);
            var obj = JsonConvert.DeserializeObject<List_Models>(dataRedis);
            return obj.data;

        }
    }
}
