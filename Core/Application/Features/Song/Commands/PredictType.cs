using Application.DTOs.Song;
using Application.DTOs.Song.SongRequest;
using Application.Exceptions;
using Application.Interfaces.Repo;
using Application.Interfaces.UoW;
using Application.Wrappers;
using Domain.Base;
using MediatR;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using ThirdPartyServices.Storage;
using ThirdPartyServices.Deeplearning;
using System.Linq;
using System.Collections.Generic;

namespace Application.Features.Song.Commands
{
    public class PredictTypeRequest
    {
        public int Id { get; set; }
        //public bool IsVN { get; set; }
    }
    public class PredictTypeCommand : PredictTypeRequest, IRequest<object>
    {
    }
    public class PredictTypeCommandHandler : IRequestHandler<PredictTypeCommand, object>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStorageService _storageService;
        private readonly IDeeplearningService _deeplearningService;
        public PredictTypeCommandHandler(IUnitOfWork unitOfWork, IStorageService storageService, IDeeplearningService deeplearningService)
        {
            _unitOfWork = unitOfWork;
            _storageService = storageService;
            _deeplearningService = deeplearningService;

        }

        public async Task<object> Handle(PredictTypeCommand request, CancellationToken cancellationToken)
        {

            var song = await _unitOfWork.SongRepo.GetByIdAsync(request.Id);
            if (song == null)
                throw new NotFoundException("Song not found");
            if (!_unitOfWork.SongRepo.CheckAuthorizeResource(song))
                throw new UnauthorizeException();          
            var rs = song.Country=="Việt Nam"? await _deeplearningService.PredictType(song.FileMusic128, true): await _deeplearningService.PredictType(song.FileMusic128, false); ;
            var rsFirst = rs[0];
            var top2Type = rsFirst.predict.OrderByDescending(pr => pr.value).Take(2).ToArray();

            float totalValue = top2Type[0].value + top2Type[1].value;
            int valueT0 = (int)((top2Type[0].value / totalValue)*100);
            int valueT1 = (int)((top2Type[1].value / totalValue)*100);

            //top2Type[0].value = valueT0;
            //top2Type[1].value = valueT1;

            var T0 = await _unitOfWork.Song_TypeRepo.GetByTwoIdAsync(request.Id, top2Type[0].typeId);
            if (T0 == null)
                await _unitOfWork.Song_TypeRepo.AddAsync(new Domain.Entities.Song_Type() { SongId = request.Id, TypeId = top2Type[0].typeId, Value = valueT0 });
            else
            {
                T0.Value = valueT0;
                _unitOfWork.Song_TypeRepo.Update(T0);
            }

            var T1 = await _unitOfWork.Song_TypeRepo.GetByTwoIdAsync(request.Id, top2Type[1].typeId);
            if (T1 == null)
                await _unitOfWork.Song_TypeRepo.AddAsync(new Domain.Entities.Song_Type() { SongId = request.Id, TypeId = top2Type[1].typeId, Value = valueT1 });
            else
            {
                T1.Value = valueT1;
                _unitOfWork.Song_TypeRepo.Update(T1);
            }

            if (!_unitOfWork.Commit())
                throw new BadRequestException("PredictType fail");
            else
            {
                //await _storageService.PredictTypeFileAsync(song.Thumbnail, 0);
                //await _storageService.PredictTypeFileAsync(song.FileMusic, 1);
                return new CommandOK<object>()
                {
                    ObjectId = song.Id,
                    Msg = "PredictType song OK",
                    Data = rs
                };
            }
        }
        private List<ThirdPartyServices.Deeplearning.DTO.ResponsePredict> Clone(List<ThirdPartyServices.Deeplearning.DTO.ResponsePredict> l)
        {
            return l;
        }
    }
}
