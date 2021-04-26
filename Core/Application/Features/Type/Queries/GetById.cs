using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.DTOs.Type;
using Application.Exceptions;
using Application.Interfaces.Repo;
using Application.Parameters;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Type.Queries
{
    public class GetByIdQuery : IRequest<Response<TypeDTO>>
    {
        public int Id { get; set; }
    }
    public class GetByIdHandler : IRequestHandler<GetByIdQuery, Response<TypeDTO>>
    {
        private readonly ITypeRepository _typeRepository;
        public GetByIdHandler(ITypeRepository typeRepository)
        {
            _typeRepository = typeRepository;
        }
        public async Task<Response<TypeDTO>> Handle(GetByIdQuery request, CancellationToken cancellationToken)
        {
            var res = await _typeRepository.GetByIdAsync(request.Id);
            if (res == null)
                throw new NotFoundException("Type not found");
                //return new NotFoundReponse<TypeDTO>();

            var data = _typeRepository.MapType(res);
            return new Response<TypeDTO>()
            {
                Data = data
            };
        }


    }
}
