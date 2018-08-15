using DwarfGame.DAL.Model;
using DwarfGame.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarfGame.DAL
{
    public class NPCRepository
    {
       
        public List<NPC> GetAll()
        {
            return Database.NPC;
        }

        public void Add(NPC npc)
        {
            Database.NPC.Add(npc);
        }

        public void Delete(Guid npc)
        {
            var itemToRemove = Database.NPC.SingleOrDefault(r => r.Id == npc);
            if (itemToRemove != null)
                Database.NPC.Remove(itemToRemove);
        }

        // haal model op op basis van id
        public NPC GetNPC(Guid id)
        {
            var result = Database.NPC.FirstOrDefault(n => n.Id == id);
            return result;
        }
       
    }
}
