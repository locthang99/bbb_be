using Application.DTOs.User;
using Application.Interfaces.Service;
using Application.Interfaces.UoW;
using Application.Parameters;
using Application.Wrappers;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Account.Base.Queries
{
    public class GetUserByKeywordQuery : PagedSortRequest, IRequest<PagedResponse<IEnumerable<UserDTO>>>
    {
        public string Keyword { get; set; }
    }
    public class GetUserByKeywordHandler : IRequestHandler<GetUserByKeywordQuery, PagedResponse<IEnumerable<UserDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetUserByKeywordHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<PagedResponse<IEnumerable<UserDTO>>> Handle(GetUserByKeywordQuery request, CancellationToken cancellationToken)
        {
            //var userId = _authenticatedUserService.GetCurrentUserId();
            int Id;
            var isNumbericId = Int32.TryParse(request.Keyword,out Id);

            List<UserDTO> data = new List<UserDTO>();
            if(isNumbericId)
            {
                var res = await _unitOfWork.AccountRepo
                    .FindByAsync(u => u.Id == Id || u.FirstName.ToLower().Contains(request.Keyword.ToLower())
                    || u.LastName.ToLower().Contains(request.Keyword.ToLower())
                    || u.Email.ToLower().Contains(request.Keyword.ToLower())
                    || (request.Keyword.ToLower().Contains(u.FirstName.ToLower()) && !string.IsNullOrEmpty(u.FirstName))
                    || request.Keyword.ToLower().Contains(u.LastName.ToLower())
                    || request.Keyword.ToLower().Contains(u.Email.ToLower()), request);
                data =res.Data.Select( u => _unitOfWork.AccountRepo.MapUser(u)).ToList();
                return new PagedResponse<IEnumerable<UserDTO>>(request)
                {
                    TotalItem = res.TotallRecord,
                    Data = data
                };
            }
            else
            {
                var res = await _unitOfWork.AccountRepo
                    .FindByAsync(u =>
                    u.FirstName.ToLower().Contains(request.Keyword.ToLower())
                    || u.LastName.ToLower().Contains(request.Keyword.ToLower())
                    || u.Email.ToLower().Contains(request.Keyword.ToLower())
                    || (request.Keyword.ToLower().Contains(u.FirstName.ToLower()) && !string.IsNullOrEmpty(u.FirstName))
                    || request.Keyword.ToLower().Contains(u.LastName.ToLower())
                    || request.Keyword.ToLower().Contains(u.Email.ToLower()), request);
                data = res.Data.Select(u => _unitOfWork.AccountRepo.MapUser(u)).ToList();
                return new PagedResponse<IEnumerable<UserDTO>>(request)
                {
                    TotalItem = res.TotallRecord,
                    Data = data
                };
            }
        }
    }
}
