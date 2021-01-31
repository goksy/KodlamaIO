using GameProject.Abstract;
using GameProject.Adapter;
using GameProject.Concrete;
using GameProject.Entitie;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player { Id = 1, NationalityId = "48628276148", FirstName = "Gökhan", LastName = "Önder", DateOfBirth = new DateTime(1989, 5, 19) };
            BasePlayerManager playerManager = new PlatformOnePlayerManager(new MernisServiceAdapter());

            Game game1 = new Game { GameId = 2, GameName = "AgeOfEmpires", Price = 12 };
            Campaign campaign1 = new Campaign { CampaignId = 3, CampaingName = "BlackFriday", Rate = 5 };

            Sale sale1 = new Sale { SaleId = 1, SalePrice = 15 };
            
            playerManager.Add(player1);

            SaleManager saleManager = new SaleManager(new CampaingManager(), new PlatformOnePlayerManager(new MernisServiceAdapter()));
            saleManager.Saling(player1, game1, campaign1);
            Console.ReadLine();
        }
    }
}
