using DwarfGame.DAL.Model;
using DwarfGame.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarfGame.DAL
{
    public class PlayerRepository
    {
        public PlayerRepository()
        {
            
        }

        public List<Player> GetAll()
        {
            return Database.Players;
        }

       


    }
}
