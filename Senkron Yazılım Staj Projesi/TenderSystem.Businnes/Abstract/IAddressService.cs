using System.Collections.Generic;
using TenderSystem.Core.Utilities.Results;
using TenderSystem.Entities.Concrete;

namespace TenderSystem.Business.Abstract
{
    public interface IAddressService
    {
        Result GetAll();
        Result GetById(int addressId);
        Result GetByClientId(int clientId);
        Result Add(Address address);
        Result Update(Address address);
        Result Delete(int addressId);
    }
}