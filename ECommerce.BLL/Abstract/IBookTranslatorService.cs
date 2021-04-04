using Core.Utilities.Results;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.BLL.Abstract
{
    public interface IBookTranslatorService
    {
        IResults Add(BookTranslator bookTranslator);

        IResults Delete(BookTranslator bookTranslator);
        IResults Update(BookTranslator bookTranslator);

        IDataResult<List<BookTranslator>> GetList();

        IDataResult<BookTranslator> GetTranslatorByBookId (int bookTranslatorId);
    }
}
