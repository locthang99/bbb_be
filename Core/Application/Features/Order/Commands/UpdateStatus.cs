using Application.DTOs.Song;
using Application.DTOs.Song.SongRequest;
using Application.Interfaces.Repo;
using Application.Wrappers;
using Domain.Base;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ThirdPartyServices.Storage;
using System.Net.Http;
using Newtonsoft.Json;
using System.Linq;
using Application.Interfaces.UoW;
using ThirdPartyServices.Payment.DTO;
using ThirdPartyServices.Payment;
using Application.Interfaces.Service;
using Application.Exceptions;

namespace Application.Features.Order.Commands
{
    public class UpdateStatusCommand : IRequest<CommandResponse<object>>
    {
        public int OrderId { get; set; }
    }
    public class UpdateStatusCommandHandler : IRequestHandler<UpdateStatusCommand, CommandResponse<object>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMomoService _momoService;
        private readonly IAuthenticatedUserService _authenService;

        public UpdateStatusCommandHandler(IUnitOfWork unitOfWork, IMomoService momoService, IAuthenticatedUserService authenService)
        {
            _unitOfWork = unitOfWork;
            _momoService = momoService;
            _authenService = authenService;

        }

        public async Task<CommandResponse<object>> Handle(UpdateStatusCommand request, CancellationToken cancellationToken)
        {
            var order = await _unitOfWork.OrderRepo.GetByIdAsync(request.OrderId);
            if (order == null)
            {
                throw new NotFoundException("Order not found");
            }

            order.Status = "Success";
            var res = _unitOfWork.OrderRepo.Update(order);

            var item = await _unitOfWork.ItemRepo.GetByIdAsync(order.ItemId);
            if (item == null)
            {
                throw new NotFoundException("Item not found");
            }

            var infoVipUser = _unitOfWork.InfoVipUserRepo.CustomFindBy(x => x.UserId == order.UserId).FirstOrDefault();
            if (infoVipUser == null)
            {
                throw new NotFoundException("Info Vip User not found");
            }
             infoVipUser.ExpireAt =  infoVipUser.ExpireAt.AddDays(item.AddTime);
            infoVipUser.Status = "ActiveVip";
            _unitOfWork.InfoVipUserRepo.Update(infoVipUser);

            var user = await _unitOfWork.AccountRepo.GetByIdAsync(order.UserId);
            if(user == null)
            {
                throw new NotFoundException("User not found");
            }
            user.UserVip = true;
            await _unitOfWork.AccountRepo.UpdateAsync(user);

            if (!_unitOfWork.Commit())
            {
                return new CommandFail<object>()
                {
                    Msg = "Update Status Order Failed"
                };
            }

            return new CommandOK<object>()
            {
                ObjectId = res.Id,
                Msg = "Update status order OK",
                Data = order,
            };
        }

    }

}
