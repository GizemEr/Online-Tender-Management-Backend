using System;
using System.Collections.Generic;
using TenderSystem.Business.Abstract;
using TenderSystem.Core.Utilities.Results;
using TenderSystem.DataAccess.Abstract;
using TenderSystem.Entities.Concrete;

namespace TenderSystem.Business.Concrete
{
    public class ImageManager : IImageService
    {
            private IImageDal _imageDal;

            public ImageManager(IImageDal imageDal)
            {
                _imageDal = imageDal;
            }

        public Result GetAll()
        {
            try
            {
                var data = _imageDal.GetList();
                return new SuccessResult(data, "Images listed.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Images could NOT listed." + exception.Message);
            }

            
        }

        public Result GetById(int imageId)
        {
            try
            {
                var data = _imageDal.Get(a => a.Id == imageId);
                if (data == null)
                {
                    return new ErrorResult("There is no image has this Id.");
                }

                return new SuccessResult(data, "Image listed.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Image could NOT listed." + exception.Message);
            }

           
        }

        public Result GetByTenderId(int tenderId)
        {
            try
            {
                var data = _imageDal.GetList(b => b.TenderId == tenderId);
                if (data == null)
                {
                    return new ErrorResult("There are no images registered to this tender id.");
                }

                return new SuccessResult(data, "Images listed.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Images could NOT listed." + exception.Message);
            }

            
        }

        public Result Add(Image image)
        {
            try
            {
                _imageDal.Add(image);
                return new SuccessResult("Image added.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Image could NOT added" + exception.Message);
            }

            
        }

        public Result Update(Image image)
        {
            try
            {
                _imageDal.Update(image);
                return new SuccessResult("Image updated.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Image could NOT updated." + exception.Message);
            }

            
        }

        public Result Delete(int imageId)
        {
            try
            {
                var data = _imageDal.Get(a => a.Id == imageId);
                if (data == null)
                {
                    return new ErrorResult("Image id could not found.");
                }

                _imageDal.Delete(data);
                return new SuccessResult("Image deleted.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Image could not deleted." + exception.Message);
            }

            
        }
    }
}