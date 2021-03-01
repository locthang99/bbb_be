using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.DTOs.User.UserRequest
{
    public class UserUpdateRequest
    {

        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public IFormFile Thumbnail { get; set; }
    }
}
