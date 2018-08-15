using DwarfGame.DAL;
using DwarfGameMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DwarfGameMVC.Controllers
{
    public class PlayerController : Controller
    {
        PlayerRepository playerRepository = new PlayerRepository();

        // GET: Player
        public ActionResult Index()
        {
            var model = new PlayerListViewModel();
            var players = playerRepository.GetAll();
            model.Players = players.Select(p => PlayerModel.FromDatabaseModel(p)).ToList();
            return View(model);
        }

       

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PlayerModel model)
        {
            if (ModelState.IsValid)
            {

                playerRepository.Add(PlayerModel.ToDatabaseModel(model));

                return RedirectToAction("Index");

            }

            return View(model);

        }
    }

}