using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5_5_Gamer
{
    class CampaignManager : ICampaignService
    {
        IUserValidationService _userValidationService;

        public CampaignManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("A user named " + gamer.FirstName + " has created a new campaign.");
            }
            else
            {
                Console.WriteLine("A user named " + gamer.FirstName + " could not be validated.");
            }
        }

        public void Delete(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("A user named " + gamer.FirstName + " deleted the campaign.");
            }
            else
            {
                Console.WriteLine("A user named " + gamer.FirstName + " could not be validated.");
            }
        }

        public void Update(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("A user named " + gamer.FirstName + " has updated the campaign.");
            }
            else
            {
                Console.WriteLine("A user named " + gamer.FirstName + " could not be validated.");
            }
        }
    }
}
