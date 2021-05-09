using Application.DTOs.User;
using Domain.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Mapping
{
    public class Mapper : IMapper
    {
        private readonly IConfiguration _config;
        public ProfileDTO MapUser(User user)
        {
            var data = new ProfileDTO()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                UserName = user.UserName,
                Dob = user.Dob,
                Email = user.Email,
                Thumbnail = user.Thumbnail

            };
            //var srcImg = _context.FileImages.Where(z => z.IdUser == user.Id && z.Description == "Thumbnail").FirstOrDefault();

            if (!user.Thumbnail.Contains("http") && user.Thumbnail != "")
                data.Thumbnail = _config["File:Image"] + user.Thumbnail;
            return data;
        }
    }
}
