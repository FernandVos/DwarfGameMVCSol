using DwarfGame.DAL.Model;
using DwarfGame.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarfGame.DAL
{
    internal static class Database
    {
        internal static List<Player> Players { get; set; } = new List<Player>();
        internal static List<NPC> NPC { get; set; } = new List<NPC>();

        static Database()
        {
            Players.AddRange(
                new[]
                {
                    new Player
                    {
                        Name = "Pietje",
                        PlayerClass = PlayerClass.Fighter,
                        PlayerRace = PlayerRace.Dwarf

                    },
                    new Player
                    {
                        Name = "Jantje",
                        PlayerClass = PlayerClass.Fighter,
                        PlayerRace = PlayerRace.Dwarf

                    },
                }
                );

            NPC.AddRange(
                new[]
                {
                    new NPC
                    {
                        Name = "Grum",
                        PlayerRace = PlayerRace.Dwarf,
                        StartGold = 100,
                        BluffChance = 5

                    },

                    new NPC
                    {
                        Name = "Olm",
                        PlayerRace = PlayerRace.Dwarf,
                        StartGold = 120,
                        BluffChance = 15

                    },

                }
                );
        }
    }
}
