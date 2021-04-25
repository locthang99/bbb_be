using Application.Exceptions;
using Application.Interfaces.Repo;
using Application.Interfaces.RepoBase;
using Application.Interfaces.UoW;
using Application.Wrappers;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Song.Commands
{

    public class UpdateSingerCommand : IRequest<Response<string>>
    {
        public int Id { get; set; }
        public int IdSingerUpdate { get; set; }

        public void SetId(int id, int idSinger)
        {
            Id = id;
            IdSingerUpdate = idSinger;
        }
    }

    public class UpdateSingerHandler : IRequestHandler<UpdateSingerCommand, Response<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAccountRepository<User> _accountRepository;

        public UpdateSingerHandler(IUnitOfWork unitOfWork, IAccountRepository<User> accountRepository)
        {
            _unitOfWork = unitOfWork;
            _accountRepository = accountRepository;
        }

        public async Task<Response<string>> Handle(UpdateSingerCommand request, CancellationToken cancellationToken)
        {
            if (request.IdSingerUpdate == 0)
                throw new BadRequestException("Id Singer not equal 0");
            var song = await _unitOfWork.SongRepo.GetByIdAsync(request.Id);
            if (song == null)
                throw new NotFoundException("Song not found");
            var Singer = await _accountRepository.GetByIdAsync(Math.Abs(request.IdSingerUpdate));
            if (Singer == null)
                throw new NotFoundException("Singer not found");
            if (!_unitOfWork.SongRepo.CheckAuthorizeResource(song))
                throw new UnauthorizeException();
            if (request.IdSingerUpdate > 0)
            {
                var song_Singer = await _unitOfWork.Song_SingerRepo.GetByTwoIdAsync(request.Id, request.IdSingerUpdate);
                if (song_Singer != null)
                    throw new BadRequestException("This Singer have been added to this song");
                var rs = await _unitOfWork.Song_SingerRepo.AddAsync(new Song_Singer() { SongId = request.Id, SingerId = request.IdSingerUpdate });
                if (_unitOfWork.Commit())
                    return new CommandOK<string>()
                    {
                        Msg = "Add Singer OK"
                    };
            }
            if (request.IdSingerUpdate < 0)
            {
                var song_Singer = await _unitOfWork.Song_SingerRepo.GetByTwoIdAsync(request.Id, -request.IdSingerUpdate);
                if (song_Singer == null)
                    throw new BadRequestException("The song dont has this Singer");
                var rs = _unitOfWork.Song_SingerRepo.Delete(song_Singer);
                if (_unitOfWork.Commit())
                    return new CommandOK<string>()
                    {
                        Msg = "Remove Singer OK"
                    };
            }
            return new CommandFail<string>()
            {
                Code = 400,
                Msg = "Update Fail",
            };

        }
    }
}
