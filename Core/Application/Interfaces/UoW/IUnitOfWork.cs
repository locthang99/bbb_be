using Application.Interfaces.Repo;
using Application.Interfaces.RepoBase;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        public ISongRepository SongRepo { get; }
        public IPlaylistRepository PlaylistRepo { get; }
        public ITagRepository TagRepo { get; }
        public IExtensionEntityRepository<Song_Tag> Song_TagRepo {get;}
        public IExtensionEntityRepository<Song_SongType> Song_TypeRepo { get; }
        public int Commit();
        public Task<int> CommitAsync();
        public void Disposable();
    }
}
