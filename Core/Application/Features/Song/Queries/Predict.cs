using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.DTOs.Song;
using Application.Exceptions;
using Application.Interfaces.Repo;
using Application.Parameters;
using Application.Wrappers;
using MediatR;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Application.Features.Song.Queries
{
    public class PredictQuery : IRequest<Response<List_PredictDTO>>
    {
        public int Id { get; set; }
        public bool IsVN { get; set; }
    }
    public class PredictHandler : IRequestHandler<PredictQuery, Response<List_PredictDTO>>
    {
        private readonly ISongRepository _songRepository;
        private readonly IHttpClientFactory _httpClientFactoty;
        public PredictHandler(ISongRepository songRepository, IHttpClientFactory httpClientFactoty)
        {
            _songRepository = songRepository;
            _httpClientFactoty = httpClientFactoty;
        }
        public async Task<Response<List_PredictDTO>> Handle(PredictQuery request, CancellationToken cancellationToken)
        {
            if (request.Id == 500)
                throw new BadRequestException("Bad");
            var res = await _songRepository.GetByIdAsync(request.Id);
            if (res == null)
                throw new NotFoundException("Song not found");
            //return new NotFoundReponse<Object>();
            var rg = request.IsVN ? "VN" : "US";
            var rs = await _httpClientFactoty.CreateClient().GetAsync("http://7c0f8674a730.ngrok.io/predict_"+rg+"/?" + res.FileMusic);
            rs.EnsureSuccessStatusCode();
            var resp = await rs.Content.ReadAsStringAsync();
            var obj = JsonConvert.DeserializeObject<List_PredictDTO>(resp);
            //var obj = Object.Parse(resp);
            
            return new Response<List_PredictDTO>()
            { 
                Msg ="Predict OK",
                Data = obj
            };
            
        }

    }
    public class List_PredictDTO
    {
        public List<PredictDTO> data { get; set; }
    }

    public class PredictDTO
    {
        public string part { get; set; }
        public object predict { get; set; }
    }

}
