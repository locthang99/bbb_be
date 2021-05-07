using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.DTOs.User.UserRequest
{
    public class ResetPasswordRequest
    {

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string ResetCode { get; set; }
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation new password do not match.")]
        public string ConfirmNewPassword { get; set; }
    }
}
