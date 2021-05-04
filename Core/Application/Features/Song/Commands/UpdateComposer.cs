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

    public class UpdateComposerCommand : IRequest<Response<string>>
    {
        public int Id { get; set; }
        public int IdComposerUpdate { get; set; }

        public void SetId(int id, int idComposer)
        {
            Id = id;
            IdComposerUpdate = idComposer;
        }
    }

    public class UpdateComposerHandler : IRequestHandler<UpdateComposerCommand, Response<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAccountRepository _accountRepository;

        public UpdateComposerHandler(IUnitOfWork unitOfWork, IAccountRepository accountRepository)
        {
            _unitOfWork = unitOfWork;
            _accountRepository = accountRepository;
        }

        public async Task<Response<string>> Handle(UpdateComposerCommand request, CancellationToken cancellationToken)
        {
            if (request.IdComposerUpdate == 0)
                throw new BadRequestException("Id Composer not equal 0");
            var song = await _unitOfWork.SongRepo.GetByIdAsync(request.Id);
            if (song == null)
                throw new NotFoundException("Song not found");
            var Composer = await _accountRepository.GetByIdAsync(Math.Abs(request.IdComposerUpdate));
            if (Composer == null)
                throw new NotFoundException("Composer not found");
            if (!_unitOfWork.SongRepo.CheckAuthorizeResource(song))
                throw new UnauthorizeException();
            if (request.IdComposerUpdate > 0)
            {
                var song_Composer = await _unitOfWork.Song_ComposerRepo.GetByTwoIdAsync(request.Id, request.IdComposerUpdate);
                if (song_Composer != null)
                    throw new BadRequestException("This Composer have been added to this song");
                var rs = await _unitOfWork.Song_ComposerRepo.AddAsync(new Song_Composer() { SongId = request.Id, ComposerId = request.IdComposerUpdate });
                if (_unitOfWork.Commit())
                    return new CommandOK<string>()
                    {
                        Msg = "Add Composer OK"
                    };
            }
            if (request.IdComposerUpdate < 0)
            {
                var song_Composer = await _unitOfWork.Song_ComposerRepo.GetByTwoIdAsync(request.Id, -request.IdComposerUpdate);
                if (song_Composer == null)
                    throw new BadRequestException("The song dont has this Composer");
                var rs = _unitOfWork.Song_ComposerRepo.Delete(song_Composer);
                if (_unitOfWork.Commit())
                    return new CommandOK<string>()
                    {
                        Msg = "Remove Composer OK"
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
