using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.DTOs.Tag;
using Application.Exceptions;
using Application.Interfaces.Repo;
using Application.Parameters;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Tag.Queries
{
    public class GetByIdQuery : IRequest<Response<TagDTO>>
    {
        public int Id { get; set; }
    }
    public class GetByIdHandler : IRequestHandler<GetByIdQuery, Response<TagDTO>>
    {
        private readonly ITagRepository _tagRepository;
        public GetByIdHandler(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }
        public async Task<Response<TagDTO>> Handle(GetByIdQuery request, CancellationToken cancellationToken)
        {
            if (request.Id == 500)
                throw new BadRequestException("Bad");
            var res = await _tagRepository.GetByIdAsync(request.Id);
            if (res == null)
                throw new NotFoundException("Tag not found");
                //return new NotFoundReponse<TagDTO>();

            var data = _tagRepository.MapTag(res);
            return new Response<TagDTO>()
            {
                Data = data
            };
        }


    }
}
