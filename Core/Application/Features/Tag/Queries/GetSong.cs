using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.DTOs.PlayList;
using Application.DTOs.Song;
using Application.Exceptions;
using Application.Interfaces.Repo;
using Application.Interfaces.UoW;
using Application.Parameters;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Tag.Queries
{
    public class GetSongQuery : PagedSortRequest, IRequest<PagedResponse<IEnumerable<SongDTO>>>
    {
        public int IdTag { get; set; }
        public void SetId(int Id)
        {
            IdTag = Id;
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
            var tag = await _unitOfWork.TagRepo.GetByIdAsync(request.IdTag);
            if(tag == null)
                throw new NotFoundException("Tag not found");
            //List<int> ListIdSong = new List<int>();

            var listS_P = await _unitOfWork.Song_TagRepo.FindByAsync(s_p => s_p.TagId == tag.Id, request);
            var ListIdSong = listS_P.Data.Select(s_p => s_p.SongId).ToList();
            var listSong = await _unitOfWork.SongRepo.GetByListIdPagedSortAsync(ListIdSong, request);
            var resListSong = listSong.Data.Select(s => _unitOfWork.SongRepo.MapSong(s)).ToList();
            return new PagedResponse<IEnumerable<SongDTO>>(request)
            {
                TotalItem = listS_P.TotallRecord,
                Data = resListSong
            };
        }
    }
}
