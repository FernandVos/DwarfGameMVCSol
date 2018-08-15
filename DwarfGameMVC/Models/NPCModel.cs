using DwarfGame.DAL.Model;
using DwarfGame.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DwarfGameMVC.Models
{
    public class NPCModel
    {
        public string Name { get; set; }
        public PlayerRace PlayerRace { get; set; }
        public int StartGold { get; set; }
        public int BluffChance { get; set; }

        public static NPCModel  FromDatabaseModel(NPC npc)
        {
            return new NPCModel
            {
                Name = npc.Name,
                PlayerRace = npc.PlayerRace,
                StartGold = npc.StartGold,
                BluffChance = npc.BluffChance
             
            };
        }
    }
}