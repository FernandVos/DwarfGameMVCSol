using DwarfGame.DAL.Model;
using DwarfGame.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DwarfGameMVC.Models
{
    public class PlayerModel
    {
        public string Name { get; set; }
        public PlayerRace PlayerRace { get; set; }
        public PlayerClass PlayerClass { get; set; }

        public static PlayerModel FromPlayer(Player player)
        {
            return new PlayerModel
            {
                Name = player.Name,
                PlayerClass = player.PlayerClass,
                PlayerRace = player.PlayerRace
            };
        }
    }
}