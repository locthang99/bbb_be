using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.User
{
    public class ProfileDTO
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool UserVip { get; set; }
        public bool VerifyEmailStatus { get; set; }
        public string Role { get; set; }
        public string Thumbnail { get; set; }
    }
}
