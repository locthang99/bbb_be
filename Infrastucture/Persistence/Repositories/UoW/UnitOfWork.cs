using Application.Interfaces.Repo;
using Application.Interfaces.RepoBase;
using Application.Interfaces.UoW;
using Domain.Entities;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly BigBlueBirdsDbContext _bigBlueBirdsDbContext;
        public ISongRepository SongRepo { get; set; }
        public IPlaylistRepository PlaylistRepo { get; set; }
        public ITagRepository TagRepo { get; set; }
        public IExtensionEntityRepository<Song_Tag> Song_TagRepo { get; set; }
        public IExtensionEntityRepository<Song_SongType> Song_TypeRepo { get; set; }
        public UnitOfWork(BigBlueBirdsDbContext bigBlueBirdsDbContext,
            ISongRepository _songRepo,
            IPlaylistRepository _playlistRepo,
            ITagRepository _tagRepo,
            IExtensionEntityRepository<Song_Tag> _song_TagRepo,
            IExtensionEntityRepository<Song_SongType> _song_TypeRepo
        )
        {
            _bigBlueBirdsDbContext = bigBlueBirdsDbContext;
            SongRepo = _songRepo;
            PlaylistRepo = _playlistRepo;
            TagRepo = _tagRepo;
            Song_TagRepo = _song_TagRepo;
            Song_TypeRepo = _song_TypeRepo;
        }

        public int Commit()
        {
            return _bigBlueBirdsDbContext.SaveChanges();
        }

        public async Task<int> CommitAsync()
        {
            return await _bigBlueBirdsDbContext.SaveChangesAsync();
        }

        public void Disposable()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _bigBlueBirdsDbContext.Dispose();
        }
    }
}
