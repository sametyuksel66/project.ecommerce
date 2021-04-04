using Core.Utilities.Results;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.BLL.Abstract
{
    public interface ICreditCartService
    {
        IResults Add(CreditCardInformation creditCard);

        IResults Delete(CreditCardInformation creditCard);
        IResults Update(CreditCardInformation creditCard);

        IDataResult<List<CreditCardInformation>> GetList();

        IDataResult<CreditCardInformation> GetCreditCartByID(int creditCartId);
    }
}
