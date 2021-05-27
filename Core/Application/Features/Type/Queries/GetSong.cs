using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.DTOs.Type;
using Application.DTOs.Song;
using Application.Exceptions;
using Application.Interfaces.Repo;
using Application.Interfaces.UoW;
using Application.Parameters;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Type.Queries
{
    public class GetSongQuery : PagedSortRequest, IRequest<PagedResponse<IEnumerable<SongDTO>>>
    {
        public int IdType { get; set; }
        public void SetId(int Id)
        {
            IdType = Id;
        }
    }
    public class GetSongHandler : IRequestHandler<GetSongQuery, PagedResponse<IEnumerable<SongDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetSongHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<PagedResponse<IEnumerable<SongDTO>>> Handle(GetSongQuery request, CancellationToken cancellationToken)
        {
            var Type = await _unitOfWork.TypeRepo.GetByIdAsync(request.IdType);
            if(Type == null)
                throw new NotFoundException("Type not found");
            //List<int> ListIdSong = new List<int>();

            var listS_P = await _unitOfWork.Song_TypeRepo.FindByAsync(s_p => s_p.TypeId == Type.Id, request);
            var ListIdSong = listS_P.Data.Select(s_p => s_p.SongId).ToList();
            var listSong = await _unitOfWork.SongRepo.GetByListIdPagedSortAsync(ListIdSong);
            var resListSong = listSong.Data.Select(s => _unitOfWork.SongRepo.MapSong(s)).ToList();
            return new PagedResponse<IEnumerable<SongDTO>>(request)
            {
                TotalItem = listS_P.TotallRecord,
                Data = resListSong
            };
        }
    }
}
