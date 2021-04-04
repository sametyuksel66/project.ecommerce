using Core.Utilities.Results;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.BLL.Abstract
{
    public interface IImageService
    {
        IResults Add(Image image);
        IResults Delete(Image image);
        IResults Update(Image image);

        IDataResult<List<Image>> GetList();

        IDataResult<Image> GetImageById(int imageId);
    }
}
