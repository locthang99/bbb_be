using Application.Features.Song.DTO;
using System;
using System.Collections.Generic;
using System.Text;


namespace Application.Features.Song.Mapper
{
    public interface ISongMapper
    {
        public SongDTO MapToSong(Domain.Entities.Song song);

    }
    public class SongMapper : ISongMapper
    {
        public SongDTO MapToSong(Domain.Entities.Song song)
        {
            throw new NotImplementedException();
        }
    }
}
