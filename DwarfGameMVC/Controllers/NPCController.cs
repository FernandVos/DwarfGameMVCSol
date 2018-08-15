using DwarfGame.DAL;
using DwarfGameMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DwarfGameMVC.Controllers
{
    public class NPCController : Controller
    {
        NPCRepository npcRepository = new NPCRepository();

        // GET: NPC

        public ActionResult Index()
        {
            var model = new NPCListViewModel();
            var NPCs = npcRepository.GetAll();
            model.NPCs = NPCs.Select(p => NPCModel.FromDatabaseModel(p)).ToList();
            return View(model);
        }
    }
}