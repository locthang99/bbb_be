using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.User
{
    public class FollowerDTO
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Status { get; set; }
        public int TotalFollower { get; set; }
        public DateTime DateCreate { get; set; }
    }
}
