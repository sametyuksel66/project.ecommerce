using Core.Utilities.Results;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.BLL.Abstract
{
    public interface IBookCategoryService
    {
        IResults Add(BookCategory bookCategory);

        IResults Delete(BookCategory bookCategory);
        IResults Update(BookCategory bookCategory);

        IDataResult<List<BookCategory>> GetList();

        IDataResult<BookCategory> GetBookByBookId(int bookId);
    }
}
