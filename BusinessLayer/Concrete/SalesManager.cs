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

        List<Campaign> _campaign;
        public SalesManager()
        {
            _campaign = new List<Campaign> { 
                new Campaign { CampaignName = "Standart" }, 
                new Campaign { CampaignName = "Vip" },
                new Campaign { CampaignName = "Premium" }};
        }

        public void Add(Campaign campaign)
        {
            _campaign.Add(campaign);
        }

        public List<Campaign> GetCampaigns()
        {
            return _campaign;
        }
    }
}
