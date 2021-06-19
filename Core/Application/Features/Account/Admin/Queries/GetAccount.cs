using Application.DTOs.User;
using Application.Interfaces.Repo;
using Application.Parameters;
using Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Account.Admin.Queries
{
    public class GetAccountQuery : PagedSortRequest, IRequest<PagedResponse<IEnumerable<UserDTO>>>
    {
        public string RoleBase {get;set;}
        public string Keyword { get; set; }
    }
    public class GetAccountHandler : IRequestHandler<GetAccountQuery, PagedResponse<IEnumerable<UserDTO>>>
    {
        private readonly IAccountRepository _accountRepository;
        public GetAccountHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public async Task<PagedResponse<IEnumerable<UserDTO>>> Handle(GetAccountQuery request, CancellationToken cancellationToken)
        {
            var res = await _accountRepository.GetAllPagedSortAsync(request,request.RoleBase,request.Keyword);
            var data = res.Data.Select(s => _accountRepository.MapUser(s)).ToList();
            return new PagedResponse<IEnumerable<UserDTO>>(request)
            {
                TotalItem = res.TotallRecord,
                Data = data
            };
        }
    }
}
