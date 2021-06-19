using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyServices.Deeplearning.DTO;

namespace ThirdPartyServices.Deeplearning
{
    public interface IDeeplearningService
    {
        Task<string> SetConfigServer(string host);
        Task<ServerInfo> GetConfigServer();
        Task<List<Model>> GetModels();
        Task<string> SaveTempFileMusic(FileObj file);
        Task<object> PredictTemp(FileObj file,bool isVN);
        Task<List<ResponsePredict>> PredictType(string nameFile, bool isVN);

    }
}
