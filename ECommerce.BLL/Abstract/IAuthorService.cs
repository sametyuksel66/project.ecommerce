using Core.Utilities.Results;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.BLL.Abstract
{
    public interface IAuthorService
    {
        IResults Add(Author author);

        IResults Delete(Author author);
        IResults Update(Author author);

        IDataResult<List<Author>> GetList();

        IDataResult<Author> GetAuthorByID(int authorId);
    }
}
