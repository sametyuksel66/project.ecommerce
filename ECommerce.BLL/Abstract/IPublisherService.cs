using Core.Utilities.Results;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.BLL.Abstract
{
    public interface IPublisherService
    {
        IResults Add(Publisher publisher);

        IResults Delete(Publisher publisher);
        IResults Update(Publisher publisher);

        IDataResult<List<Publisher>> GetList();

        IDataResult<Publisher> GetPublisherById(int id);
    }
}
