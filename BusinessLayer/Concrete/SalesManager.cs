using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class SalesManager :ICampaignDal
    {
        //Kampanyaları eklediğimiz class'ımız

        ICampaignDal _campaignDal;
        public SalesManager(ICampaignDal campaignDal)
        {
            _campaignDal = campaignDal;
        }

        public void Add(Campaign campaign)
        {
            _campaignDal.Add(campaign);
        }

        public List<Campaign> GetCampaigns()
        {
            return _campaignDal.GetCampaigns();
        }
    }
}
