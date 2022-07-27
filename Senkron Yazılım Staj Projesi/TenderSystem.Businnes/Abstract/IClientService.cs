using System.Collections.Generic;
using TenderSystem.Core.Utilities.Results;
using TenderSystem.Entities.Concrete;

namespace TenderSystem.Business.Abstract
{
    public interface IClientService
    {
        Result GetAll();
        Result GetById(int userId);
        Result GetByUserName(string userName);
        Result Add(Client client);
        Result Update(Client client);
        Result Delete(int clientId);
    }
}