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

namespace Application.Features.Item.Commands
{
    public class UpdatePriceDiscountCommand : IRequest<Response<Domain.Entities.Item>>
    {
        //[JsonIgnore]
        internal int Id { get; set; }
        public long Price { get; set; }
        public int Discount { get; set; }
        public void SetId(int id)
        {
            Id = id;
        }
    }
    public class UpdatePriceDiscountCommandHandler : IRequestHandler<UpdatePriceDiscountCommand, Response<Domain.Entities.Item>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public UpdatePriceDiscountCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response<Domain.Entities.Item>> Handle(UpdatePriceDiscountCommand request, CancellationToken cancellationToken)
        {

            var item = await _unitOfWork.ItemRepo.GetByIdAsync(request.Id);
            if (item == null)
                throw new NotFoundException("Item not found");
            //if (!_unitOfWork.ItemRepo.CheckAuthorizeResource(song))
            //    throw new UnauthorizeException();
            if (request.Price != 0)
                item.Price = request.Price;
            if (request.Discount != 0)
                item.Discount = request.Discount;

            var res = _unitOfWork.ItemRepo.Update(item);

            if (!_unitOfWork.Commit())
                throw new BadRequestException("UpdatePriceDiscount song fail");
            else
                return new CommandOK<Domain.Entities.Item>()
                {
                    ObjectId = res.Id,
                    Msg = "UpdatePriceDiscount song OK",
                    Data = res
                };
        }
    }
}
