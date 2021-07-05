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
        public ITypeRepository TypeRepo { get; }
        public IRepository<History> HistoryRepo { get; }
        public IAccountRepository AccountRepo { get; }
        public IRealEntityRepository<Item> ItemRepo { get; }
        public IRealEntityRepository<Order> OrderRepo { get; }
        public IRepository<InfoVipUser> InfoVipUserRepo { get; }
        public IExtensionEntityRepository<Follower> FollowerRepo { get; }
        public IExtensionEntityRepository<Song_PlayList> Song_PlaylistRepo { get; }
        public IExtensionEntityRepository<Song_Tag> Song_TagRepo { get; set; }
        public IExtensionEntityRepository<Song_Type> Song_TypeRepo { get; set; }
        public IExtensionEntityRepository<Song_Composer> Song_ComposerRepo { get; }
        public IExtensionEntityRepository<Song_Singer> Song_SingerRepo { get; }
        public IExtensionEntityRepository<User_Like_Song> User_Like_SongRepo { get; }
        public IExtensionEntityRepository<User_Cmt_Song> User_Comment_SongRepo { get; }
        public IExtensionEntityRepository<User_Like_Playlist> User_Like_PlaylistRepo { get; }
        public IExtensionEntityRepository<User_Cmt_Playlist> User_Comment_PlaylistRepo { get; }

        public UnitOfWork(BigBlueBirdsDbContext bigBlueBirdsDbContext,
            ISongRepository _songRepo,
            IPlaylistRepository _playlistRepo,
            ITagRepository _tagRepo,
            ITypeRepository _typeRepo,
            IRepository<History> _historyRepo,
            IAccountRepository _accountRepo,
            IRealEntityRepository<Item> _itemRepo,
            IRealEntityRepository<Order> _orderRepo,
            IRepository<InfoVipUser> _infoVipUserRepo,
            IExtensionEntityRepository<Follower> _followerRepo,
            IExtensionEntityRepository<Song_PlayList> _song_PlaylistRepo,
            IExtensionEntityRepository<Song_Tag> _song_TagRepo,
            IExtensionEntityRepository<Song_Type> _song_TypeRepo,
            IExtensionEntityRepository<User_Like_Song> _user_Like_SongRepo,
            IExtensionEntityRepository<Song_Composer> _song_ComposerRepo,
            IExtensionEntityRepository<Song_Singer> _song_SingerRepo,
            IExtensionEntityRepository<User_Cmt_Song> _user_Comment_SongRepo,
            IExtensionEntityRepository<User_Like_Playlist> _user_Like_PlaylistRepo,
            IExtensionEntityRepository<User_Cmt_Playlist> _user_Comment_PlaylistRepo
        )
        {
            _bigBlueBirdsDbContext = bigBlueBirdsDbContext;
            SongRepo = _songRepo;
            PlaylistRepo = _playlistRepo;
            TagRepo = _tagRepo;
            TypeRepo = _typeRepo;
            HistoryRepo = _historyRepo;
            FollowerRepo = _followerRepo;
            AccountRepo = _accountRepo;
            ItemRepo = _itemRepo;
            OrderRepo = _orderRepo;
            InfoVipUserRepo = _infoVipUserRepo;
            Song_PlaylistRepo = _song_PlaylistRepo;
            Song_TagRepo = _song_TagRepo;
            Song_TypeRepo = _song_TypeRepo;
            Song_ComposerRepo = _song_ComposerRepo;
            Song_SingerRepo = _song_SingerRepo;
            User_Like_SongRepo = _user_Like_SongRepo;
            User_Comment_SongRepo = _user_Comment_SongRepo;
            User_Like_PlaylistRepo = _user_Like_PlaylistRepo;
            User_Comment_PlaylistRepo = _user_Comment_PlaylistRepo;

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
            var numRecordChange = await _bigBlueBirdsDbContext.SaveChangesAsync();
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
