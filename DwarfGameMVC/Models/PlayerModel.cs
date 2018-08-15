using DwarfGame.DAL.Model;
using DwarfGame.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DwarfGameMVC.Models
{
    public class PlayerModel
    {
        [Required] public string Name { get; set; }
        [Required] public PlayerRace PlayerRace { get; set; }
        [Required] public PlayerClass PlayerClass { get; set; }

        public static PlayerModel FromDatabaseModel(Player player)
        {
            return new PlayerModel
            {
                Name = player.Name,
                PlayerClass = player.PlayerClass,
                PlayerRace = player.PlayerRace
            };
        }

        public static Player ToDatabaseModel(PlayerModel player)
        {
            return new Player
            {
                Name = player.Name,
                PlayerRace = player.PlayerRace,
                PlayerClass = player.PlayerClass

            };
        }
    }
}