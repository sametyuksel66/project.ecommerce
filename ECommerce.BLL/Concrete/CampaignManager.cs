using Business.Constants;
using Core.Utilities.Results;
using ECommerce.BLL.Abstract;
using ECommerce.DAL.Abstract;
using ECommerce.Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ECommerce.BLL.Concrete
{
    public class CampaignManager : ICampignService
    {
        ICampaignDal _campaignDal;
        public CampaignManager(ICampaignDal campaign)
        {
            _campaignDal = campaign;
        }

        public IResults Add(Campaign campaign)
        {
            _campaignDal.Add(campaign);
            return new SuccessResult(Message.ProductAdded);

        }

        public IResults Delete(Campaign campaign)
        {
            _campaignDal.Delete(campaign);
            return new SuccessResult(Message.ProductDeleted);
        }

        public IDataResult<Campaign> GetCampaignById(int campaignId)
        {
            return new SuccessDataResult<Campaign>(_campaignDal.Get(c => c.ID == campaignId));
        }

        public IDataResult<List<Campaign>> GetList()
        {
            return new SuccessDataResult<List<Campaign>>(_campaignDal.GetList().ToList());
        }

        public IResults Update(Campaign campaign)
        {
            _campaignDal.Update(campaign);
            return new SuccessResult(Message.ProdctUpdated);
        }
    }
}
