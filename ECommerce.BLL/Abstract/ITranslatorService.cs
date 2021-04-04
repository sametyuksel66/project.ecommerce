using Core.Utilities.Results;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.BLL.Abstract
{
    public interface ITranslatorService
    {
        IResults Add(Translator translator);

        IResults Delete(Translator translator);
        IResults Update(Translator translator);

        IDataResult<List<Translator>> GetList();

        IDataResult<Translator> GetTranslatorById (int id);
    }
}
