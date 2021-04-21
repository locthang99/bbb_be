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
        public IExtensionEntityRepository<Song_Type> Song_TypeRepo { get; set; }
        public IExtensionEntityRepository<User_Like_Song> User_Like_SongRepo { get; }
        public UnitOfWork(BigBlueBirdsDbContext bigBlueBirdsDbContext,
            ISongRepository _songRepo,
            IPlaylistRepository _playlistRepo,
            ITagRepository _tagRepo,
            IExtensionEntityRepository<Song_Tag> _song_TagRepo,
            IExtensionEntityRepository<Song_Type> _song_TypeRepo,
            IExtensionEntityRepository<User_Like_Song> _user_Like_SongRepo
        )
        {
            _bigBlueBirdsDbContext = bigBlueBirdsDbContext;
            SongRepo = _songRepo;
            PlaylistRepo = _playlistRepo;
            TagRepo = _tagRepo;
            Song_TagRepo = _song_TagRepo;
            Song_TypeRepo = _song_TypeRepo;
            User_Like_SongRepo = _user_Like_SongRepo;
        }

        public bool Commit()
        {
            var numRecordChange = _bigBlueBirdsDbContext.SaveChanges();
            if (numRecordChange > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> CommitAsync()
        {
            var numRecordChange =  await _bigBlueBirdsDbContext.SaveChangesAsync();
            if (numRecordChange > 0)
                return true;
            else
                return false;
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
