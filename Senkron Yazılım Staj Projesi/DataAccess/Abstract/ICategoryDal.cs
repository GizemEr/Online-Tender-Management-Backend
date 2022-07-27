using System;
using System.Linq.Expressions;
using TenderSystem.Core.DataAccess;
using TenderSystem.Entities.Concrete;

namespace TenderSystem.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        //Category GetByCategoryTitle(Expression<Func<Category, bool>> filter = null);
    }
}