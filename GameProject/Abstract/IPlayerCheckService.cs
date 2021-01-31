using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface IPlayerCheckService
    {
        bool CheckIfRealPlayer(Player player);
    }
}
