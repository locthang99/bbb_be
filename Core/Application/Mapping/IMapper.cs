using Application.DTOs.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Mapping
{
    public interface IMapper
    {
        public ProfileDTO MapUser(Domain.Entities.User user);
    }
}
