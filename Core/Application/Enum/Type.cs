using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Enum
{
    public enum  ActionType
    {
        SEARCH,
        UPDATE,
        DELETE,
        DOWNLOAD,
        LISTEN,
        LOGIN,
        LOGOUT,
        LIKE,
        COMMENT,
        SENDFRIENDREQUEST,
        ACCEPTFRIENDREQUEST,
        DENYFRIENDREQUEST
    }
    public enum ObjectType
    {
        SONG,
        PLAYLIST,
        SONGTYPE,
        USER,
        FRIEND

    }
    public enum ImageType
    {
        SYSTEM,
        INTERNET
    }

    public enum AccountType
    {
        SYSTEM,
        FACEBOOK,
        GOOGLE
    }
    public enum PlaylistType
    {
        SYSTEM,
        USER
    }
    public static class StaticID
    {
        public static Guid RoleUserId = new Guid("00000000-0000-0000-0000-000000000004");
        public static Guid RoleIdNull = new Guid("00000000-0000-0000-0000-000000000000");
    }


}
