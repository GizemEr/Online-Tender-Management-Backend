using System;
using System.Linq;
using System.Linq.Expressions;
using TenderSystem.Core.DataAccess.EntityFramework;
using TenderSystem.DataAccess.Abstract;
using TenderSystem.Entities.Concrete;

namespace TenderSystem.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, TenderSystemDbContext>, ICategoryDal
    {
        //public Category GetByCategoryTitle(Expression<Func<Category, bool>> filter = null)
        //{
        //    using (var context = new TenderSystemDbContext())
        //    {
        //        return context.Set<Category>().SingleOrDefault(filter);
        //    }
        //}
    }
}