using TenderSystem.Core.DataAccess.EntityFramework;
using TenderSystem.DataAccess.Abstract;
using TenderSystem.Entities.Concrete;

namespace TenderSystem.DataAccess.Concrete.EntityFramework
{
    public class EfAddressDal : EfEntityRepositoryBase<Address, TenderSystemDbContext>, IAddressDal
    {

    }
}
