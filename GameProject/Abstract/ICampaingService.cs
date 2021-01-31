using GameProject.Entitie;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ICampaingService
    {
        void AddCamp(Campaign campaign);
        void UpdateCamp(Campaign campaign);
        void DeleteCamp(Campaign campaign);

    }
}
