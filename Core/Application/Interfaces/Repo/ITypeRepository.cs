using Application.Interfaces.RepoBase;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Repo
{
    public interface ITypeRepository : IRealEntityRepository<Domain.Entities.Type>
    {
    }
}
