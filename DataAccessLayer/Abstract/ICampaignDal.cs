using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
   public interface ICampaignDal
    {

        // kampanyaları içeren methodumuzu SalesManeger class'ına inherit ettik.
        List<Campaign> GetCampaigns();
        void Add(Campaign campaign);
 
    }
}
