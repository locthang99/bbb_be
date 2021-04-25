using Application.DTOs.Tag;
using Application.Interfaces.RepoBase;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Repo
{
    public interface ITagRepository : IRealEntityRepository<Tag>
    {
        public TagDTO MapTag(Domain.Entities.Tag song);
    }
}
