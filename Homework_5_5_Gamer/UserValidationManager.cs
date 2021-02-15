using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5_5_Gamer
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if((gamer.BirthYear == 1900 && gamer.FirstName == "AHMET" && gamer.LastName == "MEHMET" && gamer.IdentityNumber == 57144079548)  || (gamer.BirthYear == 1990 && gamer.FirstName == "AYŞE" && gamer.LastName == "FATMA" && gamer.IdentityNumber == 435666789904))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
