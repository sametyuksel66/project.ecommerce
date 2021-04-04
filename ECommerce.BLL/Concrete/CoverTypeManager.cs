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
    public class CoverTypeManager : ICoverTypeService
    {
        ICoverTypeDal _coverTypeDal;

        public CoverTypeManager(ICoverTypeDal coverTypeDal)
        {
            _coverTypeDal = coverTypeDal;
        }

        public IResults Add(CoverType coverType)
        {
            _coverTypeDal.Add(coverType);
            return new SuccessResult(Message.ProductAdded);
        }

        public IResults Delete(CoverType coverType)
        {
            _coverTypeDal.Delete(coverType);
            return new SuccessResult(Message.ProductDeleted);
        }

        public IDataResult<CoverType> GetCoverTypeById(int coverTypeId)
        {
            return new SuccessDataResult<CoverType>(_coverTypeDal.Get(x => x.ID == coverTypeId));
        }

        public IDataResult<List<CoverType>> GetList()
        {
            return new SuccessDataResult<List<CoverType>>(_coverTypeDal.GetList().ToList());
        }

        public IResults Update(CoverType coverType)
        {
            _coverTypeDal.Update(coverType);
            return new SuccessResult(Message.ProdctUpdated);
        }
    }
}
