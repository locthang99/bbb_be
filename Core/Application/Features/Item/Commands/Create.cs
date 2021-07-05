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

namespace Application.Features.Item.Commands
{
    public class CreateCommand : IRequest<CommandResponse<InitPaymentResponse>>
    {
        public int ItemId { get; set; }
    }
    public class CreateCommandHandler : IRequestHandler<CreateCommand, CommandResponse<InitPaymentResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMomoService _momoService;
        private readonly IAuthenticatedUserService _authenService;

        public CreateCommandHandler(IUnitOfWork unitOfWork, IMomoService momoService, IAuthenticatedUserService authenService)
        {
            _unitOfWork = unitOfWork;
            _momoService = momoService;
            _authenService = authenService;

        }

        public async Task<CommandResponse<InitPaymentResponse>> Handle(CreateCommand request, CancellationToken cancellationToken)
        {
            var item = await _unitOfWork.ItemRepo.GetByIdAsync(request.ItemId);
            var order = new Domain.Entities.Order()
            {
                Name = Guid.NewGuid().ToString(),
                ItemId = request.ItemId,
                Amount = Convert.ToInt64(item.Price*(item.Discount*1.0/100)),
                DiscountAdded = item.Discount,
                UserId = _authenService.GetCurrentUserId(),
                Status= "Pending"                           
            };


            var res = await _unitOfWork.OrderRepo.AddAsync(order);

            if (!_unitOfWork.Commit())
            {
                return new CommandFail<InitPaymentResponse>()
                {
                    Msg = "Create song Failed"
                };
            }

            var initPayment = new InitRequest()
            {
                orderId = order.Name,
                orderInfo = item.Name,
                amount = order.Amount.ToString(),
                extraData = "bbb=bbb",
                requestId = order.Id.ToString(),
                notifyUrl = "https://testpaymentbbb.loca.lt/api/v1/Order/UpdateStatusOrder?OrderId="+res.Id.ToString(),
                returnUrl = "https://momo.vn"
            };
            var resInit = await _momoService.InitPayment(initPayment);
            
            return new CommandOK<InitPaymentResponse>()
            {
                ObjectId = res.Id,
                Data = resInit,
            };
        }

    }

}
