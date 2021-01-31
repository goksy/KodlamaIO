using GameProject.Abstract;
using GameProject.Entitie;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class SaleManager : ISaleService
    {
        ICampaingService _campaingService;
        IPlayerService _playerService;
        public SaleManager(ICampaingService campaingService, IPlayerService playerService)
        {
            _campaingService = campaingService;
            _playerService = playerService;
        }
        public void Saling(Player player, Game game, Campaign campaign)
        {
            decimal dicountedGame = game.Price - (game.Price * campaign.Rate / 100);

            Console.WriteLine("User : " + player.FirstName + "Game: " + game.GameName + "Total Price: " + dicountedGame + "Special Discount: " + campaign.CampaingName );
        }
    }
}
