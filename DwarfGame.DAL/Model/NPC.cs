using DwarfGame.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarfGame.DAL.Model
{
    public class NPC
    {
        public NPC()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; }
        public string Name { get; set; }
        public PlayerRace PlayerRace { get; set; }
        public int StartGold { get; set; }
        public int BluffChance { get; set; }
    }
}
