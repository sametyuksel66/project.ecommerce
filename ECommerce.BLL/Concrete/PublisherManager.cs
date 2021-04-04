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
    public class PublisherManager : IPublisherService
    {
        IPublisherDal _publisherDal;

        public PublisherManager(IPublisherDal publisherDal)
        {
            _publisherDal = publisherDal;
        }

        public IResults Add(Publisher publisher)
        {
            _publisherDal.Add(publisher);
            return new SuccessResult(Message.ProductAdded);
        }

        public IResults Delete(Publisher publisher)
        {
            _publisherDal.Delete(publisher);
            return new SuccessResult(Message.ProductDeleted);
        }

        public IDataResult<List<Publisher>> GetList()
        {
            return new SuccessDataResult<List<Publisher>>(_publisherDal.GetList().ToList());
        }

        public IDataResult<Publisher> GetPublisherById(int id)
        {
            return new SuccessDataResult<Publisher>(_publisherDal.Get(x => x.ID == id));
        }

        public IResults Update(Publisher publisher)
        {
            _publisherDal.Update(publisher);
            return new SuccessResult(Message.ProdctUpdated);
        }
    }
}
