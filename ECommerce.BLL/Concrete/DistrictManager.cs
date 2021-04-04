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
    public class DistrictManager : IDistrictService
    {
        IDistrictDal _districtDal;

        public DistrictManager(IDistrictDal districtDal)
        {
            _districtDal = districtDal;
        }

        public IResults Add(District district)
        {
            _districtDal.Add(district);
            return new SuccessResult(Message.ProductAdded);
        }

        public IResults Delete(District district)
        {
            _districtDal.Delete(district);
            return new SuccessResult(Message.ProductDeleted);
        }

        public IDataResult<District> GetDistrictById(int districtId)
        {
            return new SuccessDataResult<District>(_districtDal.Get(x => x.ID == districtId));
        }

        public IDataResult<List<District>> GetList()
        {
            return new SuccessDataResult<List<District>>(_districtDal.GetList().ToList());
        }

        public IResults Update(District district)
        {
            _districtDal.Update(district);
            return new SuccessResult(Message.ProdctUpdated);
        }
    }
}
