using ECommerce.Core.DataAccess.BaseClasses.EntityFramework;
using ECommerce.DAL.Abstract;
using ECommerce.DAL.Concrete.EntityFramework.Contexts;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace ECommerce.DAL.Concrete.EntityFramework
{
    class BookTranslatorDal : EFRepositoryBase<BookTranslator,ECommerceDBContext,int>,IBookTranslatorDal
    {
    }
}
