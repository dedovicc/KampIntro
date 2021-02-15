using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5_5_Gamer
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine(gamer.FirstName + " is registered.");
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
                Console.WriteLine("Updated");
            }
            else
            {
                Console.WriteLine("User is not validated.");
            }
        }

        public void Delete(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Deleted");
            }
            else
            {
                Console.WriteLine("User is not validated.");
            }
        }
    }
}
