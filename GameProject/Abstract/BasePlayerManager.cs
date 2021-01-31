using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public abstract class BasePlayerManager : IPlayerService
    {
        public virtual void Add(Player player)
        {
            Console.WriteLine("New player registered.");
        }

        public void Delete(Player player)
        {
            Console.WriteLine("New player deleted.");
        }

        public void Update(Player player)
        {
            Console.WriteLine("New player updated.");
        }
    }
}
