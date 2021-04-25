using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.DTOs.Comment;
using Application.DTOs.Song;
using Application.Interfaces.Repo;
using Application.Interfaces.UoW;
using Application.Parameters;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Song.Queries
{
    public class GetCommentQuery : PagedSortRequest, IRequest<PagedResponse<IEnumerable<CommentDTO>>>
    {
        public int SongId { get; set; }
    }
    public class GetCommentHandler : IRequestHandler<GetCommentQuery, PagedResponse<IEnumerable<CommentDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetCommentHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<PagedResponse<IEnumerable<CommentDTO>>> Handle(GetCommentQuery request, CancellationToken cancellationToken)
        {
            var res = await _unitOfWork.User_Comment_SongRepo.FindByAsync(c => c.SongId==request.SongId,request);
            
            var data = res.Data.Select(x => new CommentDTO() {
                UserId = x.UserId,
                FirstName = x.User.FirstName,
                LastName = x.User.LastName,
                Thumnail = x.User.Thumbnail,
                Content = x.Content,
                DateTime = x.DateCreate
            }).ToList();
            return new PagedResponse<IEnumerable<CommentDTO>>(request)
            {
                TotalItem = res.TotallRecord,
                Data = data
            };
        }
    }
}
