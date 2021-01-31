using System;

namespace GamerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1984,
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                IdentityNumber = 12345
            });

            Campaign campaign1 = new Campaign() { Id = 12, CampaignName = "Kampanya1"};
            Campaign campaign2 = new Campaign() { Id = 22, CampaignName = "Kampanya2"};

            ICampaignService campaignService = new CampaignService();
            campaignService.Add(campaign1);
            campaignService.delete(campaign2);

            Console.WriteLine("Hello World!");
        }
    }
}
