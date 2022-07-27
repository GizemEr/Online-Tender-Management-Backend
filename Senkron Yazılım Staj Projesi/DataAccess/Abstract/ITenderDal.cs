using System.Collections.Generic;
using TenderSystem.Core.DataAccess;
using TenderSystem.Entities.Concrete;

namespace TenderSystem.DataAccess.Abstract
{
    public interface ITenderDal : IEntityRepository<Tender>
    {
        List<Tender> GetListByClientId(int clientId);
    }
}
