using Core.Utilities.Results;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.BLL.Abstract
{
    public interface ILanguageService
    {
       IResults Add(Language language);

        IResults Delete(Language language);
        IResults Update(Language language);

        IDataResult<List<Language>> GetList();

        IDataResult<Language> GetLanguageById(int id);
    }
}
