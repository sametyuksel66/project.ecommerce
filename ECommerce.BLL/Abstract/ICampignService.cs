
using Core.Utilities.Results;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.BLL.Abstract
{
    public interface ICampignService
    {
        IResults Add(Campaign campaign);

        IResults Delete(Campaign campaign);
        IResults Update(Campaign campaign);

        IDataResult<List<Campaign>> GetList();

        IDataResult<Campaign> GetCampaignById(int campaignId);
    }
}
