using System.Collections.Generic;
using TenderSystem.Core.Utilities.Results;
using TenderSystem.Entities.Concrete;

namespace TenderSystem.Business.Abstract
{
    public interface ICategoryService
    {
        Result GetAll();
        Result GetById(int categoryId);
        Result Add(Category category);
        Result Update(Category category);
        Result Delete(int categoryId);
    }
}