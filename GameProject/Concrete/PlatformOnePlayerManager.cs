using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class PlatformOnePlayerManager : BasePlayerManager
    {
        private IPlayerCheckService _customerCheckService;
        public PlatformOnePlayerManager(IPlayerCheckService playerCheckService)
        {
            _customerCheckService = playerCheckService;
        }

        public override void Add(Player player)
        {
            if (_customerCheckService.CheckIfRealPlayer(player))
            {
                base.Add(player);
            }
            else
            {
                throw new Exception("Not a valid person.");
            }
            
        }
    }
}
