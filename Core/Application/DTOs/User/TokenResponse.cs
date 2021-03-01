using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.User
{
    public class TokenResponse
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
    }
}
