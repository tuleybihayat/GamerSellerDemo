using System;
using System.Collections.Generic;
using System.Text;

namespace GamerSellerDemo
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi: " + campaign.Name);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi: " + campaign.Name);
        }

        public void KampanyaUygula(Game game, Campaign campaign, Gamer gamer)
        {
            Console.WriteLine("Oyun fiyatı:" + game.Tutar);
            game.Tutar = game.Tutar - (game.Tutar * campaign.IndirimTutari / 100);
            Console.WriteLine("Oyunun indirimli fiyatı:" + game.Tutar);
            Console.WriteLine("İndirimin geçerli olduğu kullanıcı: " + gamer.FirstName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi: " + campaign.Name);



        }
    }
}
