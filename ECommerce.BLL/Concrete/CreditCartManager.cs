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
    class CreditCartManager : ICreditCartService
    {
        ICreditCardInformationDal _creditCartDal;

        public CreditCartManager(ICreditCardInformationDal creditCartDal)
        {
            _creditCartDal = creditCartDal;
        }

        public IResults Add(CreditCardInformation creditCard)
        {
            _creditCartDal.Add(creditCard);
            return new SuccessResult(Message.ProductAdded);
        }

        public IResults Delete(CreditCardInformation creditCard)
        {
            _creditCartDal.Delete(creditCard);
            return new SuccessResult(Message.ProductDeleted);
        }

        public IDataResult<CreditCardInformation> GetCreditCartByID(int creditCartId)
        {
            return new SuccessDataResult<CreditCardInformation>(_creditCartDal.Get(x => x.ID == creditCartId));
        }

        public IDataResult<List<CreditCardInformation>> GetList()
        {
            return new SuccessDataResult<List<CreditCardInformation>>(_creditCartDal.GetList().ToList());
        }

        public IResults Update(CreditCardInformation creditCard)
        {
            _creditCartDal.Update(creditCard);
            return new SuccessResult(Message.ProdctUpdated);
        }
    }
}
