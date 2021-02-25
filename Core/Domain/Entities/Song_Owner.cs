using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Song_Owner : ExtensionEntity
    {
        public int SongId { get; set; }
        public Song Song { get; set; }

        public int OwnerId { get; set; }
        public User Owner { get; set; }
        public override bool CompareTwoId(int id1,int id2)
        {
            if (SongId == id1 && OwnerId == id2)
                return true;
            else
                return false;
        }
    }
}
