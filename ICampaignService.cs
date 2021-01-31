using System;
using System.Collections.Generic;
using System.Text;

namespace GamerSellerDemo
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
        void KampanyaUygula(Game game, Campaign campaign, Gamer gamer);
    }
}
