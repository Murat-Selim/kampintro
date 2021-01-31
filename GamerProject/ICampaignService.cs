using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void delete(Campaign campaign);
        void update(Campaign campaign);
    }
}
