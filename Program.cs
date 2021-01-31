using System;

namespace GamerSellerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game() {Id=12, Tutar=756, Name="kafa topu" };
            Gamer gamer = new Gamer() { Id = 34, BirthDate = 1876, FirstName = "engin", LastName = "demiroğ", NationalityId = 1234 };
            Campaign campaign = new Campaign() { Id = 1, Name = "yüzde 30", IndirimTutari = 30 };

            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer);
            gamerManager.Update(gamer);
            gamerManager.Delete(gamer);
            Console.WriteLine();

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.Update(campaign);
            campaignManager.Delete(campaign);
            campaignManager.KampanyaUygula(game, campaign, gamer);

        }
    }
}
