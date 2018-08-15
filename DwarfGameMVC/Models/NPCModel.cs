using DwarfGame.DAL.Model;
using DwarfGame.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DwarfGameMVC.Models
{
    public class NPCModel
    {
        public Guid Id { get; set; }
        [Required (ErrorMessage ="Please enter a name")] public string Name { get; set; }
        [Required (ErrorMessage = "Please pick a race")] public PlayerRace PlayerRace { get; set; }
        [Required (ErrorMessage = "Please enter a goldvalue")] [Range (50, 200, ErrorMessage = "min 50, max 200")] public int StartGold { get; set; }
        [Required (ErrorMessage = "Please enter a bluffchance")] [Range (0, 100, ErrorMessage = "min 0, max 100")]public int BluffChance { get; set; }

        public static NPCModel FromDatabaseModel(NPC npc)
        {
            return new NPCModel
            {
                Id = npc.Id,
                Name = npc.Name,
                PlayerRace = npc.PlayerRace,
                StartGold = npc.StartGold,
                BluffChance = npc.BluffChance
             
            };
        }

        public static NPC ToDatabaseModel(NPCModel model)
        {
            return new NPC
            {
                Name = model.Name,
                PlayerRace = model.PlayerRace,
                StartGold = model.StartGold,
                BluffChance = model.BluffChance
            };
        }
    }
}