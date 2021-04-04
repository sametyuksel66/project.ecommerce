using ECommerce.Core.DataAccess.Abstract;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.DAL.Abstract
{
    public interface ILanguageDal: IEntityRepository<Language, int>
    {
    }
}
