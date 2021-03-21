using Application.DTOs.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Mapping
{
    public interface IMapper
    {
        public UserDTO MapUser(Domain.Entities.User user);
    }
}
