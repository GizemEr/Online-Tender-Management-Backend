using System.Collections.Generic;
using TenderSystem.Core.Utilities.Results;
using TenderSystem.Entities.Concrete;

namespace TenderSystem.Business.Abstract
{
    public interface IImageService
    {
        Result GetAll();
        Result GetById(int imageId);
        Result GetByTenderId(int tenderId);
        Result Add(Image image);
        Result Update(Image image);
        Result Delete(int imageId);
    }
}