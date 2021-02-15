using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5_5_Gamer
{
    interface ICampaignService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
