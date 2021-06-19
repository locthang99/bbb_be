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
    public class GetAccountByIdQuery : IRequest<Response<UserDTO>>
    {
        public int Id { get; set; }
    }
    public class GetAccountByIdHandler : IRequestHandler<GetAccountByIdQuery, Response<UserDTO>>
    {
        private readonly IAccountRepository _accountRepository;
        public GetAccountByIdHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public async Task<Response<UserDTO>> Handle(GetAccountByIdQuery request, CancellationToken cancellationToken)
        {
            var res = await _accountRepository.GetByIdAsync(request.Id);
            var data =  _accountRepository.MapUser(res);
            return new Response<UserDTO>
            {
                Msg ="Get account ok",
                Data = data
            };
        }
    }
}
