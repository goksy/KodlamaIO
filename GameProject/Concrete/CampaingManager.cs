using GameProject.Abstract;
using GameProject.Entitie;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaingManager : ICampaingService
    {
        public void AddCamp(Campaign campaign)
        {
            Console.WriteLine("New campaing added.");
        }

        public void DeleteCamp(Campaign campaign)
        {
            Console.WriteLine("campaing deleted.");
        }

        public void UpdateCamp(Campaign campaign)
        {
            Console.WriteLine("campaing updated.");
        }
    }
}
