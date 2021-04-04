using Core.Utilities.Results;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.BLL.Abstract
{
    public interface IBookService
    {

        IResults Add(Book book);

        IResults Delete(Book book);
        IResults Update(Book book);

        IDataResult<List<Book>> GetList();

        IDataResult<Book> GetBookByBookId(int BookId);
    }
}
