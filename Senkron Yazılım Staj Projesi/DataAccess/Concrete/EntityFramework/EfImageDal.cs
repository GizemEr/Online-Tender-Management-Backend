using TenderSystem.Core.DataAccess.EntityFramework;
using TenderSystem.DataAccess.Abstract;
using TenderSystem.Entities.Concrete;

namespace TenderSystem.DataAccess.Concrete.EntityFramework
{
    public class EfImageDal : EfEntityRepositoryBase<Image, TenderSystemDbContext>, IImageDal
    {

    }
}