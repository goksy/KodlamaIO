using GameProject.Entitie;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ISaleService
    {
        void Saling(Player player, Game game, Campaign campaign);
    }
}
