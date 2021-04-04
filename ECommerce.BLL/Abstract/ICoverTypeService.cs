using Core.Utilities.Results;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.BLL.Abstract
{
    public interface ICoverTypeService
    {
        IResults Add(CoverType coverType);

        IResults Delete(CoverType coverType);
        IResults Update(CoverType coverType);

        IDataResult<List<CoverType>> GetList();

        IDataResult<CoverType> GetCoverTypeById(int coverTypeId);
    }
}
