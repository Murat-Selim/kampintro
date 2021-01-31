using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject
{
    class CampaignService : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("kampanya eklendi:" + campaign.CampaignName);      
        }

        public void delete(Campaign campaign)
        {
            Console.WriteLine("kampanya silindi:" + campaign.CampaignName);
        }

        public void update(Campaign campaign)
        {
            Console.WriteLine("kampanya guncellendi:" + campaign.CampaignName);
        }
    }
}
