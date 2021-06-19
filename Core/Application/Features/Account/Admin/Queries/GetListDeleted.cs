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
    public class GetListDeletedQuery : PagedSortRequest, IRequest<PagedResponse<IEnumerable<UserDTO>>>
    {
        public string Keyword { get; set; }
    }
    public class GetListDeletedHandler : IRequestHandler<GetListDeletedQuery, PagedResponse<IEnumerable<UserDTO>>>
    {
        private readonly IAccountRepository _accountRepository;
        public GetListDeletedHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public async Task<PagedResponse<IEnumerable<UserDTO>>> Handle(GetListDeletedQuery request, CancellationToken cancellationToken)
        {
            var res = await _accountRepository.GetListDeletedPagedSortAsync(request, request.Keyword);
            var data = res.Data.Select(s => _accountRepository.MapUser(s)).ToList();
            return new PagedResponse<IEnumerable<UserDTO>>(request)
            {
                TotalItem = res.TotallRecord,
                Data = data
            };
        }
    }
}
