using System.Collections.Generic;
using TenderSystem.Core.Utilities.Results;
using TenderSystem.Entities.Concrete;

namespace TenderSystem.Business.Abstract
{
    public interface IBidService
    {
        Result GetAll();
        Result GetById(int bidId);
        Result GetByTenderId(int tenderId);
        Result GetByClientId(int clientId);
        Result Add(Bid bid);
        Result Update(Bid bid);
        Result Delete(int bidId);
    }
}