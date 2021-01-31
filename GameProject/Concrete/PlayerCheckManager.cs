using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class PlayerCheckManager : IPlayerCheckService
    {
        public bool CheckIfRealPlayer(Player player)
        {
            return true;
        }
    }
}
