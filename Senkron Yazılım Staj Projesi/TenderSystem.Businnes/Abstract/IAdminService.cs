using System.Collections.Generic;
using TenderSystem.Core.Utilities.Results;
using TenderSystem.Entities.Concrete;

namespace TenderSystem.Business.Abstract
{
    public interface IAdminService
    {
        Result GetAll();
        Result GetById(int userId);
        Result Add(Admin admin);
        Result Update(Admin admin);
        Result Delete(int adminId);
    }
}