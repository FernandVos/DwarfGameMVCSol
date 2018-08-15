using DwarfGame.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarfGame.DAL.Model
{
    public class Player
    {
        public string Name { get; set; }
        public PlayerRace PlayerRace { get; set; }
        public PlayerClass PlayerClass { get; set; }
    }
}
