using Business.Constants;
using Core.Utilities.Results;
using ECommerce.BLL.Abstract;
using ECommerce.DAL.Abstract;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.BLL.Concrete
{
    public class ImageManager:IImageService
    {
        private IImageDal _imageDal;
        public ImageManager(IImageDal imageDal)
        {
            _imageDal = imageDal;
        }

        public IResults Add(Image image)
        {
            _imageDal.Add(image);
            return new SuccessResult(Message.ProductAdded);
        }
        public IResults Delete(Image image)
        {
            _imageDal.Delete(image);
            return new SuccessResult(Message.ProductDeleted);
        }

        public IDataResult<Image> GetImageById(int imageId)
        {
            return new SuccessDataResult<Image>(_imageDal.Get(i => i.ID == imageId));
        }

        public IDataResult<List<Image>> GetList()
        {
            return new SuccessDataResult<List<Image>>(_imageDal.GetList().ToList());
        }

        public IResults Update(Image image)
        {
            _imageDal.Update(image);
            return new SuccessResult(Message.ProdctUpdated);
        }

    }
}
