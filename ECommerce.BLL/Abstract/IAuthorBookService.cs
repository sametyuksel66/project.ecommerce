using Core.Utilities.Results;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.BLL.Abstract
{
    public interface IAuthorBookService
    {
        IResults Add(BookAuthor bookAuthor);

        IResults Delete(BookAuthor bookAuthor);
        IResults Update(BookAuthor bookAuthor);

        IDataResult<List<BookAuthor>> GetList();

        IDataResult<BookAuthor> GetBookByAuthorId(int authorId);
    }
}
