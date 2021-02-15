using System;

namespace Homework_5_5_Gamer
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, FirstName = "AHMETss", LastName = "MEHMET", IdentityNumber = 57144079548, BirthYear = 1900 });

            CampaignManager campaignManager = new CampaignManager(new UserValidationManager());
            campaignManager.Add(new Gamer { Id = 1, FirstName = "AYŞE", LastName = "FATMA", IdentityNumber = 435666789904, BirthYear = 1990 });
        }
    }
}
