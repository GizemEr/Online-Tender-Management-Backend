using System;
using System.Collections.Generic;
using System.Text;
using TenderSystem.Core.DataAccess;
using TenderSystem.Entities.Concrete;

namespace TenderSystem.DataAccess.Abstract
{
    public interface ITenderStatusDal : IEntityRepository<TenderStatus>
    {
    }
}
