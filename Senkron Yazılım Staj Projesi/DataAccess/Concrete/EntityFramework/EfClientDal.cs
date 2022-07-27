using TenderSystem.Core.DataAccess.EntityFramework;
using TenderSystem.DataAccess.Abstract;
using TenderSystem.Entities.Concrete;

namespace TenderSystem.DataAccess.Concrete.EntityFramework
{
    public class EfClientDal : EfEntityRepositoryBase<Client, TenderSystemDbContext>, IClientDal
    {

    }
}